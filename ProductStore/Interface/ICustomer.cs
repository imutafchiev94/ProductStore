﻿using ProductStore.Models;

namespace ProductStore.Interface
{
    public interface ICustomer
    {
        Task<IEnumerable<Customer>> GetAll();

        Task<Customer> GetByIdCustomer(int id);

        bool Add(Customer customer);

        bool Update(Customer customer);

        bool Delete(Customer customer);

        bool Save();
    }
}
