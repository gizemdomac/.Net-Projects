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
    public partial class haberturk : System.Web.UI.Page
    {
       
        String konuid = "gundemRss";
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
            
        
        }
        private void ParseRssFile()
        {

            string RssFeedUrl = "http://www.haberturk.com/rss/"+konuid+".xml";
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
               



                foreach (Feeds prime in feeds)
                {
                   

                    //resimLink = prime.description.Substring(51, 70);
                    //  Response.Write("<script>alert('"+theDescription+"')</script>");
                    table1.Rows.Add(prime.title, prime.link, prime.pubDate, prime.description);
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("haberturk.aspx?konuid=ekonomi&konu=Ekonomi");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("haberturk.aspx?konuid=spor&konu=Spor");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
              Response.Redirect("haberturk.aspx?konuid=magazin&konu=Magazin");
        

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("haberturk.aspx?konuid=kategori/kadin&konu=Kadın");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("haberturk.aspx?konuid=kategori/siyaset&konu=Siyaset");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("haberturk.aspx?konuid=kategori/tatil&konu=Tatil");

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("haberturk.aspx?konuid=kategori/astroloji&konu=Astroloji");
        }
    }
}