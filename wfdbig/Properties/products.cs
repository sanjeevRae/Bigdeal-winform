using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Apis.Gmail.v1.Data;
using System.Diagnostics.Eventing.Reader;

namespace wfdbig.Properties
{
    public partial class products : Form
    {


        private bool panel33Visible = false;


        public products()
        {
            InitializeComponent();



            panel33.Visible = false;
            panel34.Visible = false;
            panel35.Visible = false;
            panel36.Visible = false;
            panel37.Visible = false;

            label94.Visible = false;
            label96.Visible = false;


        }



        private void PerformSearch()
        {

            string userInput = textBox1.Text.ToLower();


            if (userInput == "cargo pants" || userInput == "pants")
            {
                panel10.Visible = true;

                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = true;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = true;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = true;
                panel38.Visible = true;
                panel39.Visible = true;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;


            }
            else if (userInput == "apple Watch" || userInput == "watch" || userInput == "apple")

            {
                panel9.Visible = true;
                panel10.Visible = false;

                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = true;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = true;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;

            }
            else if (userInput == "long skirt" || userInput == "women" || userInput == "skirt" || userInput == "summer" || userInput == "long")
            {
                panel8.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;

                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }

            else if (userInput == "Adrift Hoodie" || userInput == "men" || userInput == "hoodie")

            {
                panel13.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;

                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "MSI titan GT77 laptop" || userInput == "pc" || userInput == "laptop")

            {
                panel12.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;

                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }

            else if (userInput == "Leather bag" || userInput == "bag" || userInput == "leather" || userInput == "leather bag")

            {
                panel11.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;

                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;

                panel41.Visible = true;

                panel51.Visible = false;
                panel45.Visible = true;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = true;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }

            else if (userInput == "leathe jacket" || userInput == "jacket" || userInput == "men" || userInput == "women" || userInput == "unisex" || userInput == "leather")

            {
                panel14.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;

                panel15.Visible = false;
                panel16.Visible = true;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = true;
            }
            else if (userInput == "women pants" || userInput == "pants" || userInput == "women")

            {
                panel15.Visible = true;
                panel20.Visible = true;

                panel10.Visible = true;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;

                panel16.Visible = false;
                panel17.Visible = true;
                panel18.Visible = false;
                panel19.Visible = false;

                panel38.Visible = true;
                panel39.Visible = true;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }

            else if (userInput == "Jacket" || userInput == "jacket" || userInput == "men" || userInput == "winter")
            {
                panel16.Visible = true;

                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = true;
                panel13.Visible = false;

                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = true;
            }
            else if (userInput == "Cargo washed pant" || userInput == "cargo" || userInput == "pants" || userInput == "washed" || userInput == "men")
            {
                panel17.Visible = true;
                panel10.Visible = true;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;

                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }

            else if (userInput == "cream" || userInput == "skincare" || userInput == "health" || userInput == "women")

            {
                panel18.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;

                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }

            else if (userInput == "tshirt" || userInput == "men" || userInput == "shirt")

            {
                panel19.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;

                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = true;
                panel22.Visible = false;
            }

            else if (userInput == "sorts" || userInput == "pants" || userInput == "men" || userInput == "summer")

            {
                panel38.Visible = true;
                panel39.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;

                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }



            else if (userInput == "bag" || userInput == "unisex")
            {
                panel41.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = true;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;

                panel51.Visible = false;
                panel45.Visible = true;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = true;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }



            else if (userInput == "womenbag" || userInput == "women" || userInput == "bag")
            {
                panel45.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = true;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = true;

                panel45.Visible = true;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }


            else if (userInput == "men bag" || userInput == "bag" || userInput == "unisex")
            {
                panel45.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = true;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = true;
                panel44.Visible = true;

                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "sun glasses" || userInput == "summer" || userInput == "fashion")
            {
                panel47.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;

                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "Airpods" || userInput == "apple" || userInput == "electronic" || userInput == "airpods" || userInput == "music")
            {
                panel50.Visible = true;
                panel10.Visible = false;
                panel9.Visible = true;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;

                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = true;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "Keyboard" || userInput == "gaming" || userInput == "electronic")
            {
                panel51.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = true;

                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "mouse" || userInput == "electronic")
            {
                panel53.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel51.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel44.Visible = false;

                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "airpods max" || userInput == "apple" || userInput == "airpods")
            {
                panel56.Visible = true;

                panel10.Visible = false;
                panel9.Visible = true;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = true;
                panel51.Visible = false;
                panel53.Visible = false;

                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "Digestive biscuit" || userInput == "food" || userInput == "biscuit")
            {
                panel57.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;

                panel59.Visible = true;
                panel62.Visible = true;
                panel63.Visible = true;
                panel65.Visible = true;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "tea" || userInput == "food" || userInput == "drinks" || userInput == "groceries")
            {
                panel59.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = true;

                panel62.Visible = true;
                panel63.Visible = true;
                panel65.Visible = true;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "coconut oil" || userInput == "food" || userInput == "oil" || userInput == "groceries")
            {
                panel62.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = true;
                panel59.Visible = true;

                panel63.Visible = true;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "chilli powder" || userInput == "groceries" || userInput == "food")
            {
                panel63.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = true;
                panel59.Visible = true;
                panel62.Visible = true;

                panel65.Visible = true;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "biscuit" || userInput == "food" || userInput == "groceries")
            {
                panel65.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel13.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = true;
                panel59.Visible = true;
                panel62.Visible = true;
                panel63.Visible = true;

                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "football boot" || userInput == "boot" || userInput == "shoes" || userInput == "sport")
            {
                panel75.Visible = true;


                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = true;
                panel69.Visible = true;
                panel71.Visible = true;
                panel74.Visible = true;

                panel21.Visible = false;
                panel22.Visible = false;
            }
            else if (userInput == "half tshirt" || userInput == "clothes" || userInput == "shirt" || userInput == "summer")
            {
                panel21.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = true;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;

                panel22.Visible = false;
            }
            else if (userInput == "women jacket" || userInput == "jacket" || userInput == "women")
            {
                panel22.Visible = true;
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = true;
                panel13.Visible = false;
                panel16.Visible = true;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel71.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel21.Visible = false;

            }
            else if (userInput == "women boot" || userInput == "boot" || userInput == "shoes")
            {
                panel69.Visible = true;
                panel74.Visible = true;

                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = true;

                panel71.Visible = true;

                panel75.Visible = true;
                panel21.Visible = false;
                panel22.Visible = false;
            }

            else if (userInput == "chelsa boot" || userInput == "shoes" || userInput == "boot")
            {
                panel71.Visible = true;

                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
                panel13.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel41.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel47.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel53.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel59.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel65.Visible = false;
                panel68.Visible = true;
                panel69.Visible = true;

                panel74.Visible = true;
                panel75.Visible = true;
                panel21.Visible = false;
                panel22.Visible = false;
            }

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PerformSearch();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            button1.Visible = !button1.Visible;
            button2.Visible = !button2.Visible;
            button3.Visible = !button3.Visible;
            button4.Visible = !button4.Visible;
            button5.Visible = !button5.Visible;
            button6.Visible = !button6.Visible;
            button7.Visible = !button7.Visible;
            button8.Visible = !button8.Visible;
            button9.Visible = !button9.Visible;
            button10.Visible = !button10.Visible;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            string url = "https://sanjeevrae.github.io/v1/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            string enteredText = textBox1.Text;


            labelxyz.Text = enteredText;

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                PerformSearch();
                textBox1.Clear();
                e.Handled = true;
            }


        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            //P103 gogo = new P103();
            // gogo.Show();
            // this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            P103 goo = new P103();
            goo.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            //  P103 goo = new P103();
            // goo.Show();
            // this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            panel33.Visible = !panel33Visible;


            panel33Visible = panel33.Visible;
        }

        private void label94_Click(object sender, EventArgs e)
        {
            panel33.Visible = !panel33Visible;


            panel33Visible = panel33.Visible;
            label94.Visible = true;
            label96.Visible = false;
            label95.Visible = false;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            label95.Text = "Best Match";
            labelxyz.Text = "Best Match";


            panel33.Visible = false;
            label94.Visible = false;
            label95.Visible = true;
            label96.Visible = false;

            panel10.Visible = true;
            panel13.Visible = true;
            panel11.Visible = true;
            panel14.Visible = true;
            panel15.Visible = true;
            panel16.Visible = true;
            panel17.Visible = true;
            panel18.Visible = true;
            panel19.Visible = true;
            panel20.Visible = true;
            panel38.Visible = true;
            panel39.Visible = true;
            panel41.Visible = true;
            panel21.Visible = true;
            panel9.Visible = true;
            panel8.Visible = true;
            panel22.Visible = true;
            panel12.Visible = true;
            panel56.Visible = true;
            panel50.Visible = true;
            panel69.Visible = true;
            panel71.Visible = true;
            panel44.Visible = true;
            panel45.Visible = true;
            panel47.Visible = true;
            panel51.Visible = true;
            panel53.Visible = true;
            panel57.Visible = true;
            panel59.Visible = true;
            panel62.Visible = true;
            panel63.Visible = true;
            panel65.Visible = true;
            panel68.Visible = true;
            panel74.Visible = true;



        }

        private void button12_Click(object sender, EventArgs e)
        {

            labelxyz.Text = "Rs 500 - Rs 1,500";

            label94.Visible = true;

            label95.Visible = false;
            label96.Visible = false;
            panel33.Visible = false;

            panel10.Visible = true;
            panel13.Visible = true;
            panel11.Visible = true;
            panel14.Visible = true;
            panel15.Visible = true;
            panel16.Visible = true;
            panel17.Visible = true;
            panel18.Visible = true;
            panel19.Visible = true;
            panel20.Visible = true;
            panel38.Visible = true;
            panel39.Visible = true;
            panel41.Visible = true;
            panel21.Visible = true;

            panel9.Visible = false;
            panel8.Visible = false;
            panel22.Visible = false;
            panel12.Visible = false;
            panel56.Visible = false;
            panel50.Visible = false;
            panel69.Visible = false;
            panel71.Visible = false;
            panel44.Visible = false;
            panel45.Visible = false;
            panel47.Visible = false;
            panel51.Visible = false;
            panel53.Visible = false;
            panel57.Visible = false;
            panel59.Visible = false;
            panel62.Visible = false;
            panel63.Visible = false;
            panel65.Visible = false;
            panel68.Visible = false;
            panel74.Visible = false;



        }

        private void button13_Click(object sender, EventArgs e)
        {

            labelxyz.Text = "Rs 1,500 - Rs 2,500";
            label96.Visible = true;
            label94.Visible = false;
            label95.Visible = false;

            panel33.Visible = false;

            panel9.Visible = true;
            panel8.Visible = true;
            panel22.Visible = true;

            panel10.Visible = false;
            panel13.Visible = false;
            panel11.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel38.Visible = false;
            panel39.Visible = false;
            panel41.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel12.Visible = false;
            panel56.Visible = false;
            panel50.Visible = false;
            panel69.Visible = false;
            panel71.Visible = false;
            panel44.Visible = false;
            panel45.Visible = false;
            panel47.Visible = false;
            panel51.Visible = false;
            panel53.Visible = false;
            panel57.Visible = false;
            panel59.Visible = false;
            panel62.Visible = false;
            panel63.Visible = false;
            panel65.Visible = false;
            panel68.Visible = false;
            panel69.Visible = false;
            panel74.Visible = false;





        }

        private void button14_Click(object sender, EventArgs e)
        {
            labelxyz.Text = "Rs 2,500 +";
            label95.Text = "Rs 2,500 +";
            label94.Visible = false;
            label96.Visible = false;
            panel33.Visible = false;
            label95.Visible = true;


            panel12.Visible = true;
            panel56.Visible = true;
            panel50.Visible = true;
            panel69.Visible = true;
            panel71.Visible = true;
            panel44.Visible = true;
            panel45.Visible = true;
            panel47.Visible = true;
            panel51.Visible = true;
            panel53.Visible = true;
            panel57.Visible = true;
            panel59.Visible = true;
            panel62.Visible = true;
            panel63.Visible = true;
            panel65.Visible = true;
            panel68.Visible = true;
            panel74.Visible = true;
            panel9.Visible = false;
            panel8.Visible = false;
            panel22.Visible = false;
            panel10.Visible = false;
            panel13.Visible = false;
            panel11.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel38.Visible = false;
            panel39.Visible = false;
            panel41.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel69.Visible = false;

        }

        private void label95_Click(object sender, EventArgs e)
        {
            panel33.Visible = !panel33Visible;
            panel33Visible = panel33.Visible;
            label94.Visible = false;
            label96.Visible = false;
            label95.Visible = true;
        }

        private void label96_Click(object sender, EventArgs e)
        {
            panel33.Visible = !panel33Visible;
            panel33Visible = panel33.Visible;
            label94.Visible = false;
            label96.Visible = true;
            label95.Visible = false;
        }

        private void label98_MouseEnter(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Black;
            label98.BackColor = Color.DarkGray;
            panel34.Visible = true;
            panel35.Visible = false;
            panel36.Visible = false;


        }

        private void label98_MouseLeave(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Gray;
            label98.BackColor = Color.Transparent;

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label99_MouseEnter(object sender, EventArgs e)
        {
            label99.ForeColor = Color.Black;
            label99.BackColor = Color.Silver;
            panel34.Visible = false;
            panel35.Visible = true;
            panel36.Visible = false;
            panel37.Visible = false;
        }

        private void label99_MouseLeave(object sender, EventArgs e)
        {
            label99.ForeColor = Color.Gray;
            label99.BackColor = Color.Transparent;

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label100_MouseEnter(object sender, EventArgs e)
        {
            label100.ForeColor = Color.Black;
            label100.BackColor = Color.Silver;
            panel34.Visible = false;
            panel35.Visible = false;
            panel36.Visible = true;
            panel37.Visible = false;
        }

        private void label100_MouseLeave(object sender, EventArgs e)
        {
            label100.ForeColor = Color.Gray;
            panel36.Visible = true;
            label100.BackColor = Color.Transparent;
        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void label101_MouseEnter(object sender, EventArgs e)
        {
            label101.ForeColor = Color.Black;
            panel37.Visible = true;
            label101.BackColor = Color.Silver;
            panel36.Visible = false;
            panel35.Visible = false;
        }

        private void label101_MouseLeave(object sender, EventArgs e)
        {
            label101.ForeColor = Color.Gray;
            label101.BackColor = Color.Transparent;

        }

        private void panel34_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel34_MouseEnter(object sender, EventArgs e)
        {
            panel34.Visible = true;
        }

        private void panel34_MouseLeave(object sender, EventArgs e)
        {

            panel34.Visible = false;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Black;
            label98.BackColor = Color.Silver;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Gray;
            label98.BackColor = Color.Transparent;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Black;
            label98.BackColor = Color.Silver;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Gray;
            label98.BackColor = Color.Transparent;
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Black;
            label98.BackColor = Color.Silver;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Gray;
            label98.BackColor = Color.Transparent;
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Black;
            label98.BackColor = Color.Silver;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            label98.ForeColor = Color.Gray;
            label98.BackColor = Color.Transparent;
        }

        private void button22_MouseEnter(object sender, EventArgs e)
        {
            label99.ForeColor = Color.Black;
            label99.BackColor = Color.Silver;
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            label99.ForeColor = Color.Gray;
            label99.BackColor = Color.Transparent;
        }

        private void button21_MouseEnter(object sender, EventArgs e)
        {

            label99.ForeColor = Color.Black;
            label99.BackColor = Color.Silver;
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            label99.ForeColor = Color.Gray;
            label99.BackColor = Color.Transparent;
        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {

            label99.ForeColor = Color.Black;
            label99.BackColor = Color.Silver;
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            label99.ForeColor = Color.Gray;
            label99.BackColor = Color.Transparent;
        }

        private void panel35_Click(object sender, EventArgs e)
        {

        }

        private void panel35_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button24_MouseEnter(object sender, EventArgs e)
        {
            label100.ForeColor = Color.Black;
            label100.BackColor = Color.Silver;
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            label100.ForeColor = Color.Gray;
            label100.BackColor = Color.Transparent;
        }

        private void button23_MouseEnter(object sender, EventArgs e)
        {
            label100.ForeColor = Color.Black;
            label100.BackColor = Color.Silver;
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            label100.ForeColor = Color.Gray;
            label100.BackColor = Color.Transparent;
        }

        private void button25_MouseEnter(object sender, EventArgs e)
        {
            label101.ForeColor = Color.Black;
            label101.BackColor = Color.Silver;

        }

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            label101.ForeColor = Color.Gray;
            label101.BackColor = Color.Transparent;
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            label101.ForeColor = Color.Black;
            label101.BackColor = Color.Silver;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            label101.ForeColor = Color.Gray;
            label101.BackColor = Color.Transparent;
        }

        private void button26_MouseEnter(object sender, EventArgs e)
        {
            label101.ForeColor = Color.Black;
            label101.BackColor = Color.Silver;
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            label101.ForeColor = Color.Gray;
            label101.BackColor = Color.Transparent;
        }

        private void label103_MouseEnter(object sender, EventArgs e)
        {
            label103.ForeColor = Color.Black;
        }

        private void label103_MouseLeave(object sender, EventArgs e)
        {
            label103.ForeColor = Color.Gray;
        }

        private void label104_MouseEnter(object sender, EventArgs e)
        {
            label104.ForeColor = Color.Black;
        }

        private void label104_MouseLeave(object sender, EventArgs e)
        {
            label104.ForeColor = Color.Gray;
        }

        private void label105_MouseEnter(object sender, EventArgs e)
        {
            label106.ForeColor = Color.Black;
        }

        private void label105_MouseLeave(object sender, EventArgs e)
        {
            label106.ForeColor = Color.Gray;
        }

        private void label107_MouseEnter(object sender, EventArgs e)
        {
            label107.ForeColor = Color.Black;
        }

        private void label107_MouseLeave(object sender, EventArgs e)
        {
            label107.ForeColor = Color.Gray;
        }

        private void label106_MouseEnter(object sender, EventArgs e)
        {
            label105.ForeColor = Color.Black;
        }

        private void label106_MouseLeave(object sender, EventArgs e)
        {
            label105.ForeColor = Color.Gray;
        }

        private void label102_Click(object sender, EventArgs e)
        {

            label103.Visible = !label103.Visible;
            label104.Visible = !label104.Visible;
            label105.Visible = !label105.Visible;
            label106.Visible = !label106.Visible;
            label107.Visible = !label107.Visible;
        }

        private void label97_Click(object sender, EventArgs e)
        {
            label98.Visible = !label98.Visible;
            label99.Visible = !label99.Visible;
            label100.Visible = !label100.Visible;
            label101.Visible = !label101.Visible;


        }

        private void label97_MouseEnter(object sender, EventArgs e)
        {
            panel33.Visible = false;
            panel34.Visible = false;
            panel35.Visible = false;
            panel36.Visible = false;
            panel37.Visible = false;

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Contact gog = new Contact();
            gog.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FAQ hi = new FAQ();
            hi.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
