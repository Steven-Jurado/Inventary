﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(10)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }
        //
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        //
        public string WareHousesId { get; set; }

        public WareHousesEntity HousesEntity { get; set; }
        //
        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}