using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void ProductName_SetName_ShouldSetCorrectly()
        {
            // Arrange
            var product = new Product(6, "ProductName", 50, 500);

            // Act
            var result = product.ProductName;

            // Assert
            Assert.That(result, Is.EqualTo("ProductName"));
        }

        [Test]
        public void ProductName_SetNameToNull_ShouldThrowException()
        {
            // Arrange, Act & Assert
            var result = Assert.Throws<Exception>(() => new Product(6, null, 50, 500));
            Assert.That(result.Message, Is.EqualTo("Product Name should not be null"));
        }

        [Test]
        public void ProductName_SetNameToEmpty_ShouldThrowException()
        {
            // Arrange, Act & Assert
            var result = Assert.Throws<Exception>(() => new Product(6, "", 50, 500));
            Assert.That(result.Message, Is.EqualTo("Product Name should not be null"));
        }

        [Test]
        public void ProductID_MinValue6_ShouldBeWithinValidRange()
        {
            // Arrange
            var product = new Product(6, "ProductName", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void ProductID_MinLowerBoundary5_InvalidID()
        {
            // Arrange
            var product = new Product(5, "ProductName", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Product ID is Invalid."));
        }
        [Test]
        public void ProductID_MinUpperBoundary7_ValidID()
        {
            // Arrange
            var product = new Product(7, "ProductName", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void ProductID_MaxValue60000_ShouldBeWithinValidRange()
        {
            // Arrange
            var product = new Product(60000, "ProductName", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void ProductID_MaxUpperBoundary60001_InvalidID()
        {
            // Arrange
            var product = new Product(60001, "ProductName", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Product ID is Invalid."));
        }
        [Test]
        public void ProductID_MaxLowerBoundary59999_ValidID()
        {
            // Arrange
            var product = new Product(59999, "ProductName", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }


        [Test]
        public void Price_MinValue6_ShouldBeWithinValidRange()
        {
            // Arrange
            var product = new Product(500, "ProductName", 6, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void Price_MinLowerBoundary5_InvalidID()
        {
            // Arrange
            var product = new Product(500, "ProductName", 5, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Price is Invalid."));
        }
        [Test]
        public void Price_MinUpperBoundary7_ValidID()
        {
            // Arrange
            var product = new Product(500, "ProductName", 7, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void Price_MaxValue6000_ShouldBeWithinValidRange()
        {
            // Arrange
            var product = new Product(500, "ProductName", 6000, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void Price_MaxUpperBoundary6001_InvalidID()
        {
            // Arrange
            var product = new Product(500, "ProductName", 6001, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Price is Invalid."));
        }
        [Test]
        public void Price_MaxLowerBoundary5999_ValidID()
        {
            // Arrange
            var product = new Product(500, "ProductName", 5999, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Stock_MinValue6_ShouldBeWithinValidRange()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 6);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void Stock_MinLowerBoundary5_InvalidID()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 5);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Stock is Invalid."));
        }
        [Test]
        public void Stock_MinUpperBoundary7_ValidID()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 7);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void Stock_MaxValue600000_ShouldBeWithinValidRange()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 600000);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void Stock_MaxUpperBoundary600001_InvalidID()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 600001);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Stock is Invalid."));
        }
        [Test]
        public void Stock_MaxLowerBoundary599999_ValidID()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 599999);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void IncreaseStock_ByValueTen_ShouldIncreaseStockByTen()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 500);
            int increaseAmount = 10;

            // Act
            product.IncreaseStock(increaseAmount);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(510));
        }
        [Test]
        public void IncreaseStock_ByValueZero_ShouldThrowException()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 500);
            int increaseAmount = 0;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.IncreaseStock(increaseAmount));
            Assert.That(result.Message, Is.EqualTo("Invalid amount. Amount should be greater than 0"));
        }

        [Test]
        public void IncreaseStock_MoreThanMaxCapacity_ShouldThrowException()
        {
            // Arrange
            var product = new Product(500, "ProductName", 100, 500);
            int increaseAmount = 1000000000;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.IncreaseStock(increaseAmount));
            Assert.That(result.Message, Is.EqualTo("Stock Reached to more than Max Limits"));
        }

        [Test]
        public void DecreaseStock_ByValueTen_ShouldDecreaseStockByTen()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 500);
            int decreaseAmount = 10;

            // Act
            product.DecreaseStock(decreaseAmount);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(490));
        }

        [Test]
        public void DecreaseStock_ByValueZero_ShouldThrowException()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 500);
            int decreaseAmount = 0;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.DecreaseStock(decreaseAmount));
            Assert.That(result.Message, Is.EqualTo("Invalid amount. Amount should be greater than 0"));
        }

        [Test]
        public void DecreaseStock_LessThanMinCapacity_ShouldThrowException()
        {
            // Arrange
            var product = new Product(500, "ProductName", 100, 500);
            int decreaseAmount = 1000000000;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.DecreaseStock(decreaseAmount));
            Assert.That(result.Message, Is.EqualTo("Stock Reached to less than Min Limits"));
        }

        [Test]
        public void IncreaseStock_ByNegativeAmount_ShouldThrowException()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 500);
            int increaseAmount = -10;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.IncreaseStock(increaseAmount));
            Assert.That(result.Message, Is.EqualTo("Invalid amount. Amount should be greater than 0"));
        }

        [Test]
        public void DecreaseStock_ByNegativeAmount_ShouldThrowException()
        {
            // Arrange
            var product = new Product(500, "ProductName", 500, 500);
            int decreaseAmount = -10;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.DecreaseStock(decreaseAmount));
            Assert.That(result.Message, Is.EqualTo("Invalid amount. Amount should be greater than 0"));
        }

    }
}
