using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Haberler
{
    public partial class milliyet : System.Web.UI.Page
    {
        String yeni_descriprtion;
        String resimLink;
        String konuid = "gundemRss";
        String konu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            konuid = Request.QueryString["konuid"];
            konu = Request.QueryString["konu"];
            Label1.Text ="Milliyet "+ konu;
            ParseRssFile();
        }
        class Feeds
        {
            public string title;
            public string link;
            public string pubDate;
            public string description;
            //Feeds(string a, string b, string c, string d)
            //{
            //    title = a;
            //    id = b;
            //    pubDate = c;
            //    summary=d;
            //}
        }
        private void ParseRssFile()
        {

            string RssFeedUrl = "http://www.milliyet.com.tr/rss/rssNew/"+konuid+".xml";
            List<Feeds> feeds = new List<Feeds>();
            try
            {
                XDocument xDoc = new XDocument();
                xDoc = XDocument.Load(RssFeedUrl);
                var items = (from x in xDoc.Descendants("item")
                             select new
                             {
                                 title = x.Element("title").Value,
                                 link = x.Element("link").Value,
                                 pubDate = x.Element("pubDate").Value,
                                 description = x.Element("description").Value
                             });
                
                if (items != null)
                {
                    foreach (var i in items)
                    {
                       
                        Feeds f = new Feeds
                        {
                            title = i.title,
                            link = i.link,
                            pubDate = i.pubDate,
                            description = i.description
                        };

                        feeds.Add(f);
                    }
                }
              //  Response.Write("<script>alert('Data inserted successfully')</script>");
                DataTable table1 = new DataTable();
                table1.Columns.Add("title");
                table1.Columns.Add("link");
                table1.Columns.Add("pubDate");
                table1.Columns.Add("description");
                table1.Columns.Add("resimLink");



                foreach (Feeds prime in feeds)
                {
                    for (int i = 0; i < prime.description.Length; i++)
                    {

                        if (prime.description[i] == 's' && prime.description[i + 1] == 'r' && prime.description[i + 2] == 'c' && prime.description[i + 3] == '=')
                        {
                            // Response.Write("<script>alert('" + prime.description[i+5] + "')</script>");
                            for (int j = i + 5; j < prime.description.Length; j++)
                            {
                                if (prime.description[j] == '"')
                                {
                                    resimLink = prime.description.Substring(i + 5, (j - (i + 5)));
                                    //  Response.Write("<script>alert('" + resimLink + "')</script>");
                                }
                            }
                        }

                        if (prime.description[i] == '&' && prime.description[i + 1] == 'g' && prime.description[i + 2] == 't')
                        {
                            //  Response.Write("<script>alert('" + prime.description[i+3] + "')</script>");
                            yeni_descriprtion = prime.description.Substring(i + 4);

                        }
                    }

                    //resimLink = prime.description.Substring(51, 70);
                    //  Response.Write("<script>alert('"+theDescription+"')</script>");
                    table1.Rows.Add(prime.title, prime.link, prime.pubDate, yeni_descriprtion, resimLink);
                    //Response.Write("<script>alert('"+prime.title+"  "+prime.description+"')</script>"); 
                }
                DataList1.DataSource = table1;
                DataList1.DataBind();


                // gvRss.DataSource = feeds;
                // gvRss.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("milliyet.aspx?konuid=magazinRss&konu=Magazin");
            

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
          
            Response.Redirect("milliyet.aspx?konuid=gundemRss&konu=Gundem");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=egitimRss&konu=Egitim");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=ekonomiRss&&konu=Ekonomi");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=dunyaRss&konu=Dunya");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=siyasetRss&konu=Siyaset");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=teknolojiRss&konu=Teknoloji");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=sondakikaRss&konu=SonDakika");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=milliyettatilRss&konu=Tatil");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=konutemlakRss&konu=KonutEmlak");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=otomobilRss&konu=Otomobil");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=aileRss&konu=Aile");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=saglikRss&konu=Saglik");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("milliyet.aspx?konuid=kitapRss&konu=Kitap");
        }
    }
}