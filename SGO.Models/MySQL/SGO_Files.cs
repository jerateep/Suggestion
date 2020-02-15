using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_Files
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SGO_ID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public byte[] bin_file { get; set; }
        public string ContentType { get; set; }
        public string FullPath { get; set; }
    }
}
