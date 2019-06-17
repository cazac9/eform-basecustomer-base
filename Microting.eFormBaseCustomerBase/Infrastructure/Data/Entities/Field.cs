﻿using System.ComponentModel.DataAnnotations;
using Microting.eFormApi.BasePn.Abstractions;
using Microting.eFormApi.BasePn.Infrastructure.Database.Base;

namespace Microting.eFormBaseCustomerBase.Infrastructure.Data.Entities
{
    public class Field : BaseEntity, IDataAccessObject<CustomersPnDbAnySql>
    {
        [StringLength(50)]
        public string Name { get; set; }

        public void Read(CustomersPnDbAnySql dbContext)
        {
            throw new System.NotImplementedException();
        }

        public void Create(CustomersPnDbAnySql dbContext)
        {
            dbContext.Fields.Add(this);
            dbContext.SaveChanges();
        }

        public void Update(CustomersPnDbAnySql dbContext)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(CustomersPnDbAnySql dbContext)
        {
            throw new System.NotImplementedException();
        }
    }
}