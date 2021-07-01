using NUnit.Framework;

namespace PizdaBot.Tests
{
    public class Tests
    {
        [TestCase("да", true)]
        [TestCase("Да", true)]
        [TestCase("дА", true)]
        [TestCase("ДА", true)]
        [TestCase("Д А", true)]
        [TestCase(" ДА", true)]
        [TestCase("ДА ", true)]
        [TestCase("da", true)]
        [TestCase("dА", true)]
        [TestCase("дA", true)]
        [TestCase("DA", true)]
        [TestCase("Да!", true)]
        [TestCase("да.", true)]
        [TestCase("Да...", true)]
        [TestCase("да!!!", true)]
        [TestCase("Ну, наверно, да.", true)]
        [TestCase("Ну, наверно,да.", true)]
        [TestCase("прово-да", true)]
        [TestCase("Ну да, наверно.", false)]
        [TestCase("нет", false)]
        [TestCase("ма-да-м", false)]
        [TestCase("мадам", false)]
        [TestCase("провода", false)]
        public void Da(string text, bool result)
        {
            Assert.AreEqual(result, Helper.IsDa(text));
        }
        
        [TestCase("нет", true)]
        [TestCase("Нет", true)]
        [TestCase("нЕт", true)]
        [TestCase("НЕТ", true)]
        [TestCase("Н Е Т", true)]
        [TestCase(" НЕТ", true)]
        [TestCase("Н ЕТ ", true)]
        [TestCase("net", true)]
        [TestCase("nет", true)]
        [TestCase("нEt", true)]
        [TestCase("NET", true)]
        [TestCase("Нет!", true)]
        [TestCase("нет.", true)]
        [TestCase("нет...", true)]
        [TestCase("Нет!!!", true)]
        [TestCase("Ну, наверно, нет.", true)]
        [TestCase("Ну, наверно,нет.", true)]
        [TestCase("ми-нет", true)]
        [TestCase("Ну нет, наверно.", false)]
        [TestCase("да", false)]
        [TestCase("мо-нет-о", false)]
        [TestCase("кларнетист", false)]
        [TestCase("кларнет", false)]
        public void Net(string text, bool result)
        {
            Assert.AreEqual(result, Helper.IsNet(text));
        }
    }
}