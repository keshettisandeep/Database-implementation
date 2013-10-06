using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {


    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        double res = web.add(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
        TextBox3.Text = Convert.ToString(res);
        
        string connectionStringTestDb = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
        //string dbString = "Data Source= .\SQLEXPRESS;AttachDbFilename=|DataDirectory|ArithmeticDatabase.mdf; Integrated Security=True;User Instance=True";
        SqlConnection myConnection = new SqlConnection(connectionStringTestDb);

         
        try
        {
            myConnection.Open();
            Console.WriteLine("successfully connected database");          
             string arithOper= "add";
          string myquery;     
          myquery = "insert into Arithmetic values('" + TextBox1.Text + "' , '" + TextBox2.Text + "','" + TextBox3.Text+"','"+arithOper+"')";
          SqlCommand updatecom = new SqlCommand(myquery, myConnection);
          updatecom.ExecuteNonQuery();
          myConnection.Close();
            
        }
        catch (SqlException ex)
        {
            Console.WriteLine("You failed!" + ex.Message);
        }


       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        double res = web.sub(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
        TextBox3.Text = Convert.ToString(res);


        string connectionStringTestDb = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
        //string dbString = "Data Source= .\SQLEXPRESS;AttachDbFilename=|DataDirectory|ArithmeticDatabase.mdf; Integrated Security=True;User Instance=True";
        SqlConnection myConnection = new SqlConnection(connectionStringTestDb);


        try
        {
            myConnection.Open();
            Console.WriteLine("successfully connected database");
            string arithOper = "subtract";
            string myquery;
            myquery = "insert into Arithmetic values('" + TextBox1.Text + "' , '" + TextBox2.Text + "','" + TextBox3.Text + "','" + arithOper + "')";
            SqlCommand updatecom = new SqlCommand(myquery, myConnection);
            updatecom.ExecuteNonQuery();
            myConnection.Close();

        }
        catch (SqlException ex)
        {
            Console.WriteLine("You failed!" + ex.Message);
        }


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        double res = web.mul(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
        TextBox3.Text = Convert.ToString(res);
        string connectionStringTestDb = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
        //string dbString = "Data Source= .\SQLEXPRESS;AttachDbFilename=|DataDirectory|ArithmeticDatabase.mdf; Integrated Security=True;User Instance=True";
        SqlConnection myConnection = new SqlConnection(connectionStringTestDb);


        try
        {
            myConnection.Open();
            Console.WriteLine("successfully connected database");
            string arithOper = "multiply";
            string myquery;
            myquery = "insert into Arithmetic values('" + TextBox1.Text + "' , '" + TextBox2.Text + "','" + TextBox3.Text + "','" + arithOper + "')";
            SqlCommand updatecom = new SqlCommand(myquery, myConnection);
            updatecom.ExecuteNonQuery();
            myConnection.Close();

        }
        catch (SqlException ex)
        {
            Console.WriteLine("You failed!" + ex.Message);
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        double res = web.div(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
        TextBox3.Text = Convert.ToString(res);
        string connectionStringTestDb = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
        //string dbString = "Data Source= .\SQLEXPRESS;AttachDbFilename=|DataDirectory|ArithmeticDatabase.mdf; Integrated Security=True;User Instance=True";
        SqlConnection myConnection = new SqlConnection(connectionStringTestDb);


        try
        {
            myConnection.Open();
            Console.WriteLine("successfully connected database");
            string arithOper = "division";
            string myquery;
            myquery = "insert into Arithmetic values('" + TextBox1.Text + "' , '" + TextBox2.Text + "','" + TextBox3.Text + "','" + arithOper + "')";
            SqlCommand updatecom = new SqlCommand(myquery, myConnection);
            updatecom.ExecuteNonQuery();
            myConnection.Close();

        }
        catch (SqlException ex)
        {
            Console.WriteLine("You failed!" + ex.Message);
        }

    }
    
}