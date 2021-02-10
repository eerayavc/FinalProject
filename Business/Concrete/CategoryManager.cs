﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //Business katmanı veri bağlıdır.Bağımlılığımızı minimize ediyoruz
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) //bağımlılığı azaltıyoruz
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();

            
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId); 
        }
    }
}
