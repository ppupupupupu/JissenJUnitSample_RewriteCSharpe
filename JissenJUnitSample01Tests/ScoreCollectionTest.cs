using JissenJUnitSample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JissenJUnitSample01Tests
{
    [TestFixture]
    public class ScoreCollectionTest
    {
        public class SimpleScoreable : Scoreable
        {
            int returnNumber;


            public SimpleScoreable( int returnNumber )
            {
                this.returnNumber = returnNumber;
            }


            public int GetScore()
            {
                return returnNumber;
            }
        }





        [Test( Description = "2つの数値の算術平均を返す" )]
        public void answersArithmeticMeanOfTwoNumbers()
        {
            // Arrange
            var collection = new ScoreCollection();
            collection.Add( new SimpleScoreable( 5 ) );
            collection.Add( new SimpleScoreable( 7 ) );

            // Act
            var actualResult = collection.arithmeticMean();

            // Assert
            Assert.That( actualResult , Is.EqualTo( 6 ) );
        }
    }
}
