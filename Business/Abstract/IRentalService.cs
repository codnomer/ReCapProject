﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Uptate(Rental rental);
        IDataResult<List<RentalDetailDto>> GetRentalDto();
        IDataResult<List<Rental>> GetAll();
    }
}
