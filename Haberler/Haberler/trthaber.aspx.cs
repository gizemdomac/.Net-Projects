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
    public partial class trthaber : System.Web.UI.Page
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
          
            public string description;
            public string resimLink;



        }
        private void ParseRssFile()
        {

            string RssFeedUrl = "http://www.trt.net.tr/rss/"+konuid+".rss";
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
                                 description = x.Element("description").Value,
                                 resimLink = x.Element("enclosure").Attribute("url").Value
                             });
                if (items != null)
                {
                    foreach (var i in items)
                    {
                        Feeds f = new Feeds
                        {
                            title = i.title,
                            link = i.link,
                            
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
              
                table1.Columns.Add("description");
                table1.Columns.Add("resimLink");




                foreach (Feeds prime in feeds)
                {


                    table1.Rows.Add(prime.title, prime.link,  prime.description, prime.resimLink);
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
            Response.Redirect("trthaber.aspx?konuid=gundem&konu=Gündem");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("trthaber.aspx?konuid=turkiye&konu=Türkiye");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("trthaber.aspx?konuid=dunya&konu=Dünya");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("trthaber.aspx?konuid=spor&konu=Spor");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("trthaber.aspx?konuid=ekonomi&konu=Ekonomi");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("trthaber.aspx?konuid=saglik&konu=Sağlık");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("trthaber.aspx?konuid=kultursanat&konu=Kültür Sanat");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("trthaber.aspx?konuid=cevre&konu=Çevre");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("trthaber.aspx?konuid=ekonomi&konu=Ekonomi");
        }

    }
}