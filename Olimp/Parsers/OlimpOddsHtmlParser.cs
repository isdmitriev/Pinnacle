using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using Olimp.Dto;
using System.Globalization;
namespace Olimp.Parsers
{
    class OlimpOddsHtmlParser
    {

        public (string  name1,decimal ? k1, string  name2, decimal ? k2, string  name3, decimal ? k3) GetLineThree(HtmlNode lineContainer)
        {

            string  name1=null;
            decimal? k1=null;

            string name2=null;
            decimal? k2=null;

            string name3=null;
            decimal? k3=null;


            int i = 0;
            foreach(HtmlNode node in lineContainer.ChildNodes)
            {
                if (node.OriginalName == "div")
                {
                    i = i + 1;
                    string divClassValue = this.GetAtributeValueByName(node, "class");

                    if(divClassValue.Contains("coefkeeper empty") ==false)
                    {

                        var result = this.GetOdd(node);

                        if (i==1)
                        {
                            name1 = result.name;
                            k1 = result.coef;


                        }
                        else if (i==2)
                        {
                            name2 = result.name;
                            k2 = result.coef;
                        }
                        else 
                        {
                            name3 = result.name;
                            k3 = result.coef;
                        }
                    }
                }

                
            }

            return (name1,k1,name2,k2,name3,k3);
        }


        public (string name1, decimal? k1, string name2, decimal? k2) GetLineTwo(HtmlNode lineContainer)
        {

            string name1 = null;
            decimal? k1 = null;

            string name2 = null;
            decimal? k2 = null;

            


            int i = 0;
            foreach (HtmlNode node in lineContainer.ChildNodes)
            {
                if (node.OriginalName == "div")
                {
                    i = i + 1;
                    string divClassValue = this.GetAtributeValueByName(node, "class");

                    if (divClassValue.Contains("coefkeeper empty") == false)
                    {

                        var result = this.GetOdd(node);

                        if (i == 1)
                        {
                            name1 = result.name;
                            k1 = result.coef;


                        }
                        else if (i == 2)
                        {
                            name2 = result.name;
                            k2 = result.coef;
                        }
                       
                    }
                }


            }

            return (name1, k1, name2, k2);
        }


        private (string  name,decimal ? coef) GetOdd(HtmlNode node)
        {
            string name="";
            decimal coef = 0.0M;
            
            foreach(HtmlNode nodeContend in node.ChildNodes[1].ChildNodes)
            {
                if ( nodeContend.OriginalName=="div" && this.GetAtributeValueByName(nodeContend, "class").Contains("lineNameDiv") == true)
                {
                    name = nodeContend.ChildNodes[0].InnerText;
                }
                else if(nodeContend.OriginalName == "div")
                {
                    coef = decimal.Parse(nodeContend.ChildNodes[0].InnerText, CultureInfo.InvariantCulture);
                }
                else
                {
                    continue;
                }

            }

            return (name, coef);
        }


        private string GetAtributeValueByName(HtmlNode htmlNode, string atributeName)
        {
            string value = "";
            foreach (HtmlAttribute htmlAttribute in htmlNode.Attributes)
            {
                if (htmlAttribute.Name == atributeName)
                {
                    value = htmlAttribute.Value;
                }
            }
            return value;
        }
    }
}
