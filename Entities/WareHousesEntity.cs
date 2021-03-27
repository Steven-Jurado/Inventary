using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WareHousesEntity
    {
        [Key]
        [StringLength(200)]
        public string WareHousesId { get; set; }

        [Required]
        [StringLength(100)]
        public string WareHousesName { get; set; }

        [Required]
        [StringLength(100)]
        public string WareHousesAddress { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
