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
    public partial class tgrthaber : System.Web.UI.Page
    {

        String konuid = "";
        String konu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            konuid = Request.QueryString["konuid"];
            konu = Request.QueryString["konu"];
            Label1.Text = konu;
            ParseRssFile();
        }
        class Feeds
        {
            public string title;
            public string link;
            public string pubDate;
            public string description;
            public string resimLink;



        }
        private void ParseRssFile()
        {

            string RssFeedUrl = "http://www.tgrthaber.com.tr/feed/"+konuid+"/index.rss";
            List<Feeds> feeds = new List<Feeds>();
            try
            {
                XDocument xDoc = new XDocument();
                xDoc = XDocument.Load(RssFeedUrl);
                XNamespace dcM = "http://search.yahoo.com/mrss/";
                var items = (from x in xDoc.Descendants("item")
                             select new
                             {
                                 title = x.Element("title").Value,
                                 link = x.Element("link").Value,
                                 pubDate = x.Element("pubDate").Value,
                                 description = x.Element("description").Value,
                                 resimLink = (string) x.Element(dcM+ "thumbnail").Attribute("url").Value
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
                            description = i.description,
                            resimLink = i.resimLink
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


                    table1.Rows.Add(prime.title, prime.link,prime.pubDate, prime.description, prime.resimLink);
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
            Response.Redirect("tgrthaber.aspx?konuid=manset&konu=Manşet");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=sondakika&konu=Son Dakika");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=dunya&konu=Dünya");
        }

       

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=gundem&konu=Gündem");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=politika&konu=Politika");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=spor&konu=Spor");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=magazin&konu=Magazin");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=saglik&konu=Sağlık");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=egitim&konu=Eğitim");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("tgrthaber.aspx?konuid=ekonomi&konu=Ekonomi");
        }
    }
}