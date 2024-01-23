using ClassLibraryHeroesVsMonster;
namespace TestProjectHeroesVsMonster
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HeroLifeReduction_ShouldReduceLifeCorrectly()
        {
            // Arrange
            int heroLife = 1000, monsterAttack = 200, reduction = 30;
            bool isDefending = false;
            string heroName = "Archer";

            // Act
            int newHeroLife = Metodos.heroLifeReduction(heroLife, isDefending, monsterAttack, reduction, heroName);

            // Assert
            Assert.IsTrue(newHeroLife <= heroLife);
            Assert.IsTrue(newHeroLife >= 0);

        }
        [TestMethod]
        public void HeroLifeReduction_ShouldReduceLifeFalse()
        {
            // Arrange
            int heroLife = 1000, monsterAttack = 200, reduction = 30;
            bool isDefending = false;
            string heroName = "Archer";

            // Act
            int newHeroLife = Metodos.heroLifeReduction(heroLife, isDefending, monsterAttack, reduction, heroName);

            // Assert
            Assert.IsFalse(newHeroLife > heroLife);
            Assert.IsFalse(newHeroLife < 0);
        }
        [TestMethod]
        public void CalcAtack_ShouldReturnCorrectAttackForArcher()
        {
            // Arrange
            int archerAttack = 200;

            // Act
            int result = Metodos.CalcAtack(1, archerAttack, 150, 300, 70);

            // Assert
            Assert.AreEqual(archerAttack, result);
        }
        [TestMethod]
        public void CalcAtack_ShouldReturnFalseAttackForArcher()
        {
            // Arrange
            int archerAttack = 200;

            // Act
            int result = Metodos.CalcAtack(1, archerAttack, 150, 300, 70);

            // Assert
            Assert.AreEqual(archerAttack, result);
        }

        [TestMethod]
        public void CalcAtack_ShouldReturnCorrectAttackForBarbarian()
        {
            // Arrange
            int barbarianAttack = 150;

            // Act
            int result = Metodos.CalcAtack(2, 200, barbarianAttack, 300, 70);

            // Assert
            Assert.AreEqual(barbarianAttack, result);
        }
        [TestMethod]
        public void CalcAtack_ShouldReturnFalseAttackForBarbarian()
        {
            // Arrange
            int barbarianAttack = 150;

            // Act
            int result = Metodos.CalcAtack(2, 200, barbarianAttack, 300, 70);

            // Assert
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void CalcAtack_ShouldReturnCorrectAttackForMagician()
        {
            // Arrange
            int magicianAttack = 300;

            // Act
            int result = Metodos.CalcAtack(3, 200, 150, magicianAttack, 70);

            // Assert
            Assert.AreEqual(magicianAttack, result);
        }
        [TestMethod]
        public void CalcAtack_ShouldReturnFalseAttackForMagician()
        {
            // Arrange
            int magicianAttack = 300;

            // Act
            int result = Metodos.CalcAtack(3, 200, 150, magicianAttack, 70);

            // Assert
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void CalcAtack_ShouldReturnCorrectAttackForDruid()
        {
            // Arrange
            int druidAttack = 70;

            // Act
            int result = Metodos.CalcAtack(4, 200, 150, 300, druidAttack);

            // Assert
            Assert.AreEqual(druidAttack, result);
        }
        [TestMethod]
        public void CalcAtack_ShouldReturnFalseAttackForDruid()
        {
            // Arrange
            int druidAttack = 70;

            // Act
            int result = Metodos.CalcAtack(4, 200, 150, 300, druidAttack);

            // Assert
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void CalcAtack_ShouldReturnZeroForInvalidHero()
        {
            // Act
            int result = Metodos.CalcAtack(5, 200, 150, 300, 70);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void DruidSpecialHability_ShouldAdd500ToLife_WhenLifeIsGreaterThanZero()
        {
            // Arrange
            int initialLife = 100;

            // Act
            int newLife = Metodos.DruiSpecialHability(initialLife);

            // Assert
            int expectedLife = initialLife + 500;
            Assert.AreEqual(expectedLife, newLife);
        }

        [TestMethod]
        public void DruidSpecialHability_ShouldReturnZero_WhenLifeIsZeroOrNegative()
        {
            // Arrange
            int initialLife = 0;

            // Act
            int newLife = Metodos.DruiSpecialHability(initialLife);

            // Assert
            Assert.AreEqual(0, newLife);
        }
        [TestMethod]
        public void RangSelectors_ShouldReturnTrue_WhenNumberIsWithinRange()
        {
            // Arrange
            int num = 5;
            int lessValue = 1;
            int maxValue = 10;

            // Act
            bool result = Metodos.RangSelectors(num, lessValue, maxValue, 3);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RangSelectors_ShouldReturnFalse_WhenNumberIsBelowRange()
        {
            // Arrange
            int num = 0;
            int lessValue = 1;
            int maxValue = 10;

            // Act
            bool result = Metodos.RangSelectors(num, lessValue, maxValue, 3); 

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RangSelectors_ShouldReturnFalse_WhenNumberIsAboveRange()
        {
            // Arrange
            int num = 15;
            int lessValue = 1;
            int maxValue = 10;

            // Act
            bool result = Metodos.RangSelectors(num, lessValue, maxValue, 3); 

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetRandomValueOrder_ShouldReturnValidRandomValue()
        {
            // Arrange
            int minValue = 1;
            int maxValue = 4;
            int[] numeros = new int[] { 2, 3, 4 };  // Puedes ajustar estos valores según tus necesidades
            int life1 = 10;  // Ajusta estos valores según tus necesidades
            int life2 = 20;
            int life3 = 30;
            int life4 = 40;

            // Act
            int result = Metodos.GetRandomValueOrder(minValue, maxValue, numeros, life1, life2, life3, life4);

            // Assert
            Assert.IsTrue(result >= minValue && result <= maxValue);
        }
        [TestMethod]
        public void GetRandomValueOrder_ShouldReturnInvalidRandomValue()
        {
            // Arrange
            int minValue = 1;
            int maxValue = 4;
            int[] numeros = new int[] { 2, 3, 4 };  // Puedes ajustar estos valores según tus necesidades
            int life1 = 10;  // Ajusta estos valores según tus necesidades
            int life2 = 20;
            int life3 = 30;
            int life4 = 40;

            // Act
            int result = Metodos.GetRandomValueOrder(minValue, maxValue, numeros, life1, life2, life3, life4);

            // Assert
            Assert.IsFalse(result < minValue || result > maxValue);
            
        }

        [TestMethod]
        public void MonsterLifeReduction_ShouldReturnNonFalseValue()
        {
            // Arrange
            int monsterLife = 100;
            int monsterReduction = 20;
            int heroTurn = 1;
            int archerAttack = 30;
            int barbarianAttack = 40;
            int magicianAttack = 50;
            int druidAttack = 60;

            // Act
            int result = Metodos.monsterLifeReducction(monsterLife, monsterReduction, heroTurn, archerAttack, barbarianAttack, magicianAttack, druidAttack);

            // Assert
            Assert.IsTrue(result >= 0, "La vida del monstruo no debe ser negativa");
        }

        [TestMethod]
        public void MonsterLifeReduction_ShouldReturnNonTrueValue()
        {
            // Arrange
            int monsterLife = 100;
            int monsterReduction = 20;
            int heroTurn = 1;
            int archerAttack = 30;
            int barbarianAttack = 40;
            int magicianAttack = 50;
            int druidAttack = 60;

            // Act
            int result = Metodos.monsterLifeReducction(monsterLife, monsterReduction, heroTurn, archerAttack, barbarianAttack, magicianAttack, druidAttack);

            // Assert
            Assert.IsFalse(result < 0);
        }



    }
}