using System;
using System.Globalization;
using parking_lot;
using Xunit;

namespace parking_lot_test
{
    public class parking_lot_facts
    {
        private readonly Car _car;
        private ParkingLot _parkingLot;
        private const int parkingLotSize = 20;
        
        public parking_lot_facts()
        {
            _car = new Car();
            _parkingLot = new ParkingLot();
        }
        
        [Fact]
        public void should_park_a_car_into_a_parking_lot_which_has_space_and_get_a_ticket()
        {
            var ticket = _parkingLot.Park(_car);

            Assert.NotNull(ticket);
        }
        
//        given 一个停车场和一个有效小票 when 我去停车场取车 then 我可以取到我停的那辆车
        [Fact]
        public void should_get_the_car_given_valid_ticket_to_take_the_car()
        {
            var ticket = _parkingLot.Park(_car);

            var myCar = _parkingLot.GetCar(ticket);
            
            Assert.Equal(_car, myCar);
        }

        [Fact]
        public void should_not_take_the_car_when_given_a_invalid_ticket()
        {
            var ticketInvalid = new object();


            Assert.Throws<Exception>(() => _parkingLot.GetCar(ticketInvalid));
        }

        [Fact]
        public void should_not_get_the_car_when_given_a_ticket_has_used()
        {
            var ticketUseWithSecond = _parkingLot.Park(_car);

            var car = _parkingLot.GetCar(ticketUseWithSecond);
            
            Assert.Equal(_car, car);

            Assert.Throws<Exception>(() => _parkingLot.GetCar(ticketUseWithSecond));
        }

        [Fact]
        public void should_not_park_car_when_parkinglot_is_full()
        {
            for (int i = 0; i < parkingLotSize; i++)
            {
                _parkingLot.Park(new Car());
            }

            Assert.Throws<Exception>(() => _parkingLot.Park(new Car()));
        }
        
    }
}