using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;
using Keys = OpenQA.Selenium.Keys;

namespace ChurchBookingBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        
        private IWebDriver webDriver;

        private void Form1_Load(object sender, EventArgs e)
        {
            DownloadWebDriver();
            OpenPage();
            

        }

        public void DownloadWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver();

        }

        public void OpenPage() {
            this.webDriver.Navigate().GoToUrl(@"https://unite180.com/church_bookings/booking.php");
            IWebElement banner = webDriver.FindElement(By.ClassName("m-portlet__body"));
            bool isDisplayed = banner.Displayed;
           
            while(isDisplayed == true) {

            
            
            
            };
           
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            fillInForm();
         
        }

        public void fillInForm() {
            IWebElement name = webDriver.FindElement(By.Name("name"));
            IWebElement surname = webDriver.FindElement(By.Name("surname"));
            IWebElement number = webDriver.FindElement(By.Name("cell"));
            IWebElement email = webDriver.FindElement(By.Name("email"));
            IWebElement identity = webDriver.FindElement(By.Name("id_number"));
            IWebElement question1 = webDriver.FindElement(By.Name("question1"));
            IWebElement question2 = webDriver.FindElement(By.Name("question2"));
            IWebElement question3 = webDriver.FindElement(By.Name("question3"));


            name.SendKeys(name_txt.Text);
            surname.SendKeys(surname_txt.Text);
            number.SendKeys(contact_txt.Text);
            email.SendKeys(email.Text);
            identity.SendKeys(ID_txt.Text);

            name.SendKeys(Keys.Return);
            surname.SendKeys(Keys.Return);
            number.SendKeys(Keys.Return);
            email.SendKeys(Keys.Return);
            identity.SendKeys(Keys.Return);

            SelectElement selectQ1 = new SelectElement(question1);
            selectQ1.SelectByValue("No");
            SelectElement selectQ2 = new SelectElement(question2);
            selectQ2.SelectByValue("No");
            SelectElement selectQ3 = new SelectElement(question3);
            selectQ3.SelectByValue("No");

            IWebElement submit = webDriver.FindElement(By.Name("question3"));
            submit.Click();

        }
        public void ServiceBooking()
        {



        }
    }
}
