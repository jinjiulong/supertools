using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperTools.Data.Entity
{
    [Table("t_project")]
    public class Project
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("appenvip")]
        public string AppEnvIp { get; set; } = string.Empty;

        [Column("appenvport")]
        public long Appenvport { get; set; } = 0;

        [Column("appenvusername")]
        public string AppEnvUsername { get; set; } = string.Empty;

        [Column("appenvpassword")]
        public string AppEnvPassword { get; set; } = string.Empty;

        [Column("dbip")]
        public string DbIp { get; set; } = string.Empty;

        [Column("dbport")]
        public long DbPort { get; set; } = 0;

        [Column("dbuser")]
        public string DbUser { get; set; } = string.Empty;

        [Column("dbpassword")]
        public string DbPassword { get; set; } = string.Empty;

        [Column("dbenvusername")]
        public string DbEnvUsername { get; set; } = string.Empty;

        [Column("dbenvpassword")]
        public string DbEnvPassword { get; set; } = string.Empty;

        [Column("clientpath")]
        public string ClientPath { get; set; } = string.Empty;

        [Column("appadminusername")]
        public string AppAdminUsername { get; set; } = string.Empty;

        [Column("appadminpassword")]
        public string AppAdminPassword { get; set; } = string.Empty;
    }
}
