﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars =  new List<Car>
                {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 200, Description = "Car1" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 500, Description = "Car2" },
                new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2019, DailyPrice = 150, Description = "Car3" },
                new Car { Id = 4, BrandId = 2, ColorId = 3, ModelYear = 2010, DailyPrice = 100, Description = "Car4" },
                new Car { Id = 5, BrandId = 1, ColorId = 4, ModelYear = 2018, DailyPrice = 200, Description = "Car5" }
                 };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id); ;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
