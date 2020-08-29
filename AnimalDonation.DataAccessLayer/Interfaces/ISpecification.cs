﻿using AnimalDonation.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalDonation.DataAccessLayer.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T o);
        ISpecification<T> And(ISpecification<T> specification);
        ISpecification<T> Or(ISpecification<T> specification);
        ISpecification<T> Not(ISpecification<T> specification);
    }
}
