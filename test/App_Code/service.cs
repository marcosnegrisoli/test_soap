using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://www.summitlink.net/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class service : System.Web.Services.WebService
{
    public class QuoteRequest
    {
        public String name { get; set; }
    }

    public class QuoteResponse
    {
        public Decimal value { get; set; }
    }


    public service()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public QuoteResponse getQuote(QuoteRequest request)
    {
        return new QuoteResponse() { value = 0 };
    }

}
