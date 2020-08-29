﻿using AnimalDonation.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalDonation.DataAccessLayer.Specifications
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T o);
        

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }


        public ISpecification<T> Not(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            throw new NotImplementedException();
        }
    }
}
