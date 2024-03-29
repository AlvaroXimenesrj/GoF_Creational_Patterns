﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPatterns.Models.Singleton
{
    [Table("WebsiteMetadata")]
    public class WebsiteMetadata
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(40)]
        public string DefaultTheme { get; set; }
        [Required]
        [StringLength(50)]
        public string AdminEmail { get; set; }
        [Required]
        public bool LogErrors { get; set; }


        private static WebsiteMetadata instance;
        private WebsiteMetadata() { }
        public static WebsiteMetadata GetInstance()
        {
            if (instance == null)
            {
                using (AppDbContext db = new AppDbContext())
                {
                    if (db.Metadata.Count() == 0)
                    {
                        db.Metadata.Add(new WebsiteMetadata()
                        {
                            Title = "My Application",
                            AdminEmail = "admin@localhost",
                            DefaultTheme = "Summer",
                            LogErrors = true
                        });
                        db.SaveChanges();
                    }
                    instance = db.Metadata.SingleOrDefault();
                }
            }
            return instance;
        }
    }
}