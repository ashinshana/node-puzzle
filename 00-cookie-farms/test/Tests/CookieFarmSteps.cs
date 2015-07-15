using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Tests
{
    [Binding]
    public sealed class CookieFarmSteps
    {
        public double CookiesToBuyAFarm;
        public double Frequency;
        public double CookiesToWin;
        public double TotalTime;

        [Given(@"I enter following values:")]
        public void GivenIEnterFollowingValues(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                string field = tableRow["field"];
                string value = tableRow["values"];

                switch(field)
                {
                    case "Cookies To Buy A Farm":
                        // Saving value in Feature Context Key, So that I can get this value from any place in the feature
                        FeatureContext.Current.Add("CookiesToBuyAFarm", value);
                        break;
                    case "Frequency":
                        FeatureContext.Current.Add("Frequency", value);
                        break;
                    case "Cookies To Win":
                        FeatureContext.Current.Add("CookiesToWin", value);
                        break;
                }
            }

            CookiesToBuyAFarm = double.Parse(FeatureContext.Current["CookiesToBuyAFarm"].ToString());
            Frequency = double.Parse(FeatureContext.Current["Frequency"].ToString());
            CookiesToWin = double.Parse(FeatureContext.Current["CookiesToWin"].ToString());
        }

        [When(@"I start playing the game")]
        public void WhenIStartPlayingTheGame()
        {
            TotalTime = CookieFarm.Program.CalculateTime(CookiesToBuyAFarm, Frequency, CookiesToWin);
        }

        [Then(@"I want to see total time '(.*)' seconds")]
        public void ThenIWantToSeeTotalTimeSeconds(Decimal totalTimeExpected)
        {
            Assert.AreEqual(totalTimeExpected, Math.Round(TotalTime, 7));
        }

    }
}
