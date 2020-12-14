using System;
using FluentAssertions;
using NUnit.Framework;
using UnitTestsTarget;


namespace UnitTests
{
    public class DayShiftServiceTest
    {
        [Test]
        public void DayShiftService_Business()
                {
                    // Arrange
                    var today = new DateTime(2020, 12, 14);
        
                    var service = new DayShiftService(new DayOfWeekService());
                    
                    // Act
                    var result = service.GetShiftBusinessDay(today, 1);
                    
                    // Assert
                    result.Should().Be(new DateTime(2020, 12, 15));
                }
        
        [Test]
        public void DayShiftService_Weekend_next_year()
                {
                    // Arrange
                    var today = new DateTime(2020, 12, 31);
        
                    var service = new DayShiftService(new DayOfWeekService());
                    
                    // Act
                    var result = service.GetShiftBusinessDay(today, 2);
                    
                    // Assert
                    result.Should().Be(new DateTime(2021, 01, 04));
                }
        
        [Test]
        public void DayShiftService_Business_negative()
                {
                    // Arrange
                    var today = new DateTime(2020, 12, 31);
        
                    var service = new DayShiftService(new DayOfWeekService());
                    
                    // Act
                    var result = service.GetShiftBusinessDay(today, -10);
                    
                    // Assert
                    result.Should().Be(new DateTime(2020, 12, 21));
                }
        
        [Test]
        public void DayShiftService_Weekend_negative()
                {
                    // Arrange
                    var today = new DateTime(2020, 12, 31);
        
                    var service = new DayShiftService(new DayOfWeekService());
                    
                    // Act
                    var result = service.GetShiftBusinessDay(today, -5);
                    
                    // Assert
                    result.Should().Be(new DateTime(2020, 12, 25));
                }
    }
    
    
}