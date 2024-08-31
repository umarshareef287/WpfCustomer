using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic.Core;

namespace WpfCustomerApp
{
    class MetadataHelper
    {
        private readonly ApplicationDbContext _context;

        public MetadataHelper(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<string> GetColumnNames()
        {
            var entityType = _context.Model.FindEntityType(typeof(Customer));
            var columnNames = entityType.GetProperties().Select(p => p.Name).ToList();
            return columnNames;
        }

        public IEnumerable<Customer> GetCustomer(string selectedDbColumn, string searchText)
        {
            var query = $"{selectedDbColumn}.Contains(@0)";

            // Execute the query using Dynamic LINQ
            var customers = _context.Customers
                .Where(query, searchText) // Pass the searchText as a parameter
                .ToList();

            return customers;
        }

        //public IEnumerable<Customer> GetCustomer(string selectedDbColumn, string searchText)
        //{
        //    if (selectedDbColumn == "Name")
        //    {
        //        return GetCustomersByName(searchText);
        //    }
        //    else if (selectedDbColumn == "Type")
        //    {
        //        return GetCustomersByType(searchText);
        //    }
        //    else if (selectedDbColumn == "Category")
        //    {
        //        return GetCustomersByCategory(searchText);
        //    }
        //    else if (selectedDbColumn == "Address")
        //    {
        //        return GetCustomersByAddress(searchText);
        //    }
        //    else if (selectedDbColumn == "Mobile")
        //    {
        //        return GetCustomersByMobile(searchText);
        //    }
        //    else if (selectedDbColumn == "Telephone")
        //    {
        //        return GetCustomersByTelephone(searchText);
        //    }
        //    else if (selectedDbColumn == "Fax")
        //    {
        //        return GetCustomersByFax(searchText);
        //    }
        //    else
        //    {
        //        return GetAllCustomers(searchText);
        //    }
        //}

        //public IEnumerable<Customer> GetCustomersByName(string searchText)
        //{
        //    var customers = _context.Customers
        //    .Where(c => c.Name.Contains(searchText))
        //    .ToList();
        //    return customers;
        //}

        //public IEnumerable<Customer> GetCustomersByType(string searchText)
        //{
        //    var customers = _context.Customers
        //    .Where(c => c.Type.Contains(searchText))
        //    .ToList();
        //    return customers;
        //}

        //public IEnumerable<Customer> GetCustomersByCategory(string searchText)
        //{
        //    var customers = _context.Customers
        //    .Where(c => c.Category.Contains(searchText))
        //    .ToList();
        //    return customers;
        //}

        //public IEnumerable<Customer> GetCustomersByAddress(string searchText)
        //{
        //    var customers = _context.Customers
        //    .Where(c => c.Address.Contains(searchText))
        //    .ToList();
        //    return customers;
        //}

        //public IEnumerable<Customer> GetCustomersByMobile(string searchText)
        //{
        //    var customers = _context.Customers
        //    .Where(c => c.Mobile.Contains(searchText))
        //    .ToList();
        //    return customers;
        //}

        //public IEnumerable<Customer> GetCustomersByTelephone(string searchText)
        //{
        //    var customers = _context.Customers
        //    .Where(c => c.Telephone.Contains(searchText))
        //    .ToList();
        //    return customers;
        //}

        //public IEnumerable<Customer> GetCustomersByFax(string searchText)
        //{
        //    var customers = _context.Customers
        //    .Where(c => c.Fax.Contains(searchText))
        //    .ToList();
        //    return customers;
        //}

        //public IEnumerable<Customer> GetAllCustomers(string searchText)
        //{
        //    return _context.Customers.ToList();
        //}
    }
}
