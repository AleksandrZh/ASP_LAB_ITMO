﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASP.MVC.Lab03.WebMVCR1.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();

        public int NumberOfPerson => persons.Count();
        public IEnumerable<Person> GetAllResponses => persons;

        public void AddResponse(Person pers)
        {
            persons.Add(pers);
        }
    }
}