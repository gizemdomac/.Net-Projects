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
    public partial class cnnturk : System.Web.UI.Page
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
            public string image;


        }
        private void ParseRssFile()
        {
            string a = "ersin";
            string b = "gizem";
            string c=a+"  "+ b+"'i seviyor";
            string RssFeedUrl = "https://www.cnnturk.com/feed/rss/"+konuid+"/news";
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
                                 image=x.Element("image").Value,
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
                            description = i.description,
                            image=i.image
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
                table1.Columns.Add("image");




                foreach (Feeds prime in feeds)
                {


                    //resimLink = prime.description.Substring(51, 70);
                    //  Response.Write("<script>alert('"+theDescription+"')</script>");
                    table1.Rows.Add(prime.title, prime.link, prime.pubDate, prime.description,prime.image);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("cnnturk.aspx?konuid=all&konu=Son Dakika Haberleri");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cnnturk.aspx?konuid=dunya&konu=Dünya Haberleri");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("cnnturk.aspx?konuid=turkiye&konu=Türkiye haberleri");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("cnnturk.aspx?konuid=kultur-sanat&konu=Kültür-Sanat Haberleri");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("cnnturk.aspx?konuid=bilim-teknoloji&konu=Bilim-Teknoloji Haberleri");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("cnnturk.aspx?konuid=magazin&konu=Magazin Haberleri");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("cnnturk.aspx?konuid=ekonomi&konu=Ekonomi Haberleri");
        }
    }
}