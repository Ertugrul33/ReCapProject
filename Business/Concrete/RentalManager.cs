using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {

            var result = CheckReturnDate(rental.CarId);
            if (!result.Success)
            {
                return new ErrorResult(result.Message);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(result.Message);

        }

        public IResult CheckReturnDate(int carId)
        {
            var result = _rentalDal.GetRentalDetails(x => x.CarId == carId && x.ReturnDate == null);
            if (result.Count > 0)
            {
                return new ErrorResult(Messages.RentalAddedError);
            }
            return new SuccessResult(Messages.RentalAdded);

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(re => re.Id == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(x => x.CarId == carId));
        }

        public IResult Update(Rental rental)
        {
            if (IsExist(rental.Id).Success)
            {
                var rentalToUpdate = GetById(rental.Id);
                if (rental.CarId.Equals(null) || rental.CarId.Equals(0))
                {
                    rental.CarId = rentalToUpdate.Data.CarId;
                }
                if (rental.CustomerId.Equals(null) || rental.CustomerId.Equals(0))
                {
                    rental.CustomerId = rentalToUpdate.Data.CustomerId;
                }
                if (rental.RentDate.Equals(null) || rental.RentDate.Equals(DateTime.MinValue))
                {
                    rental.RentDate = rentalToUpdate.Data.RentDate;
                }
                rental.ReturnDate = DateTime.MinValue;
                _rentalDal.Update(rental);
                return new SuccessResult(Messages.RentalUpdated);
            }
            return new ErrorResult(Messages.RentalNotFound);
        }

        public IResult UpdateReturnDate(int Id)
        {
            var result = _rentalDal.GetAll(x => x.CarId == Id);
            var updatedRental = result.LastOrDefault();
            if (updatedRental.ReturnDate != null)
            {
                return new ErrorResult();
            }
            updatedRental.ReturnDate = DateTime.Now;
            _rentalDal.Update(updatedRental);
            return new SuccessResult();
        }

        private IResult IsExist(int rentalId)
        {
            var rentalExist = GetById(rentalId);
            if (rentalExist.Data != null)
            {
                return new SuccessResult(Messages.RentalExists);
            }
            return new ErrorResult(Messages.RentalNotFound);
        }
    }
}
