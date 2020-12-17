using DaWae;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaWae.Scripts
{
    public partial class clientserver
    {

        string strHostName = "";
        public string hrefurl12was()
        {
            return "wh-187941.ds-host.ru/";
        }
        /*
        Functions c50bc0dd8a7e3b4d = new Functions();
        public string hrefurl12was()
        {
            string ab525402fd68938 = "JTu0ItGFQT3D9hoZzaodAg==";
            string fd315abfba = "nby0QjVVh/Kj+Q7ePxnS2g==";
            string e08a55706324e3cd2dbc7c28bbee916 = "ePQNtWUGRNIVOoDobnHQRQ==";
            string cafee66c13c6b359c1028a80380b = "G8i7JIb/16jnqcEteTfzFA==";
            string bfd3d2 = "iKBwlUpLrJbwa8vd0CDorQ==";
            string e916d9bb42d942438 = "nGUlbTa0UUmhddbxVGuUpg==";
            string f86dd7bf1116dc = "kPxl0arjPPJgsZy4rjRZ/A==";
            string ad17a032379aa1df0b96 = "gLme6BrlgeHTzT/z3PQPLw==";
            string bc098c10285bf1e6e0c956a6 = "TdTSmPJ7UQrMiWgRKTU3iA==";
            string c6598334e078bff8f156603a204ae34 = "gYbHoqvwvd3IYVmQJEi01g==";
            string d11fa9155d1d721 = "OVJ+RTcCHXAxcZ1Yg/aQqw==";
            string fe9d12c50bc0dd8a7e3b4df2a625a = "EZ0KUM0Q0G1bATfwk79oKg==";
            string d71287dce714724e0a59fe239e20 = "YkI6VT4S8cNiZeDEicu2oQ==";
            string b79358b06544b0b56a = "DwyM8wV+swfo9czu9Z0yZw==";
            string dcb494e1cfed2c4641eb4833 = "CweL0/JmrHD5oIe4yG9XZg==";
            string b4d8eda6747a4456ea5f386cae4 = "7ExpfOc74IRySlW3ienxYQ==";
            string e900ef9374 = "RZk3ePvrCb3D3RZ4s2dJUQ==";
            string c91a1ad0b6bf41aba97606740e9 = "ePF7UUJAVhXa6/DjSIsSQQ==";
            string ddfc8488b7685cdaa6 = "z9Zv0smnY9xsA17JoF/bSQ==";
            string fbbd7c30 = "NhAspiFrHNzTdHVdXFVHqg==";
            string wee2cf046963b915c = c50bc0dd8a7e3b4d.Decrypt(fe9d12c50bc0dd8a7e3b4df2a625a, "e8007f1b5056f819", "19da1e48de4e4e8c", "SHA256", 2, "dd7f3a992e6a7093", 256)+ c50bc0dd8a7e3b4d.Decrypt(ddfc8488b7685cdaa6, "45095e3e3f29ea73", "e91907bcf8de57ca", "SHA256", 2, "2ecf296b124e11a1", 256)+ c50bc0dd8a7e3b4d.Decrypt(fbbd7c30, "db74b024a320e498", "00b6b7be75f16fb3", "SHA256", 2, "2e2847ea8acf4e45", 256);
            string waa0082c560b = c50bc0dd8a7e3b4d.Decrypt(ab525402fd68938, "5232a2a94360340e", "73bdd17063631907", "SHA256", 2, "c87a024f10155ed2", 256);
            string w6fc38eeac2fadbff9e4ba311d06 = c50bc0dd8a7e3b4d.Decrypt(d71287dce714724e0a59fe239e20, "5c9a99a358627bf6", "5260cd4311e338d8", "SHA256", 2, "62541894a30ce20f", 256)+c50bc0dd8a7e3b4d.Decrypt(b79358b06544b0b56a, "49db78a9195f26fd", "d25ef0f654ef97b4", "SHA256", 2, "fdac50d176de4c7d", 256);
            string wd7697570462f7562b = $"{c50bc0dd8a7e3b4d.Decrypt(ad17a032379aa1df0b96, "1e5630927fd65d3d", "6d2f2870a6c4f7e5", "SHA256", 2, "f47d2a878cc633da", 256)}{c50bc0dd8a7e3b4d.Decrypt(bc098c10285bf1e6e0c956a6, "a7f05049d11062e1", "85393414f86dd7bf", "SHA256", 2, "3505d020116d112e", 256)}{c50bc0dd8a7e3b4d.Decrypt(c6598334e078bff8f156603a204ae34, "e0687aaa8689e196", "3a543c929de5edc8", "SHA256", 2, "2423fa7f5cafc277", 256)}";
            string waeba47c17 = c50bc0dd8a7e3b4d.Decrypt(c91a1ad0b6bf41aba97606740e9, "cd174733a1ed0d35", "e018cea793362472", "SHA256", 2, "1cf870e298128ac4", 256)+ c50bc0dd8a7e3b4d.Decrypt(f86dd7bf1116dc, "43bccde4816808e7", "15e922d2d8a00b9a", "SHA256", 2, "263c307cc734b444", 256);
            string c8ywd798g2e98fh2f = wee2cf046963b915c + waa0082c560b;
            string waf5f23a0b2650653b8178408f4 = c50bc0dd8a7e3b4d.Decrypt(fd315abfba, "4158e5d5a3329a10", "bb10a5ad4db1a37c", "SHA256", 2, "25f6e417a7de6d9e", 256)+ c50bc0dd8a7e3b4d.Decrypt(e08a55706324e3cd2dbc7c28bbee916, "82143d5631c6aacf", "80c3cfc7a5d19555", "SHA256", 2, "4a979c1c13861da3", 256);
            string w6b690fa3cc = c50bc0dd8a7e3b4d.Decrypt(d11fa9155d1d721, "4cdc7a325f082399", "467b437fdbd3c9bc", "SHA256", 2, "2c17821c86cba223", 256);
            string awdawrwe21 = wd7697570462f7562b + w6b690fa3cc;
            string a6324e3cd2dbc7c = $"{awdawrwe21}://{waeba47c17}";
            //string wad87yaw87dg87a2 = $"http://nonsuch+{waeba47c17}.proxy.ru";
            string c50bc0dd8a7e3b = $"{w6fc38eeac2fadbff9e4ba311d06}-{c8ywd798g2e98fh2f}.{waf5f23a0b2650653b8178408f4}/";
            string w615730494b4ab4 = c50bc0dd8a7e3b4d.Decrypt(cafee66c13c6b359c1028a80380b, "a411cfe253c1144e", "7dad535cb3fd8824", "SHA256", 2, "e5d61a5820c81ba1", 256)+ c50bc0dd8a7e3b4d.Decrypt(bfd3d2, "892e9be79b3445b5", "ace330ab62f25b5b", "SHA256", 2, "f775409e9978049e", 256)+ c50bc0dd8a7e3b4d.Decrypt(e916d9bb42d942438, "217738811703fa4f", "fbdb222be08e400d", "SHA256", 2, "5f4b14b1673803b9", 256)+ c50bc0dd8a7e3b4d.Decrypt(dcb494e1cfed2c4641eb4833, "9f0f1f9933d5463c", "ca2101cde4ced61f", "SHA256", 2, "6c4b07d40a1f0f29", 256);
            string w3cf0b660 = c50bc0dd8a7e3b4d.Decrypt(b4d8eda6747a4456ea5f386cae4, "130790feced08212", "5deab5f40575a1d3", "SHA256", 2, "75af01e3da4105cf", 256)+ c50bc0dd8a7e3b4d.Decrypt(e900ef9374, "e9c288cb6d751a32", "d81f8134d62c3082", "SHA256", 2, "7a5be8f2ada68aae", 256);
            string adw98dybn9872yr8f9e2 = w615730494b4ab4 + w3cf0b660;
            return $"{a6324e3cd2dbc7c}-{adw98dybn9872yr8f9e2}.{c50bc0dd8a7e3b}";
        }
        */
        public string get1()
        {
            try
            {
                    var request = (HttpWebRequest)WebRequest.Create($"{hrefurl12was()}nonsuch/get1.php");
                    request.Timeout = 120000;
                    var postData = "get=True";
                    postData += "&date=" + DateTime.Now.ToString();
                    postData += "&pcuser=" + strHostName;
                    var dat = Encoding.ASCII.GetBytes(postData);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = dat.Length;

                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(dat, 0, dat.Length);
                    }
                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    MessageBox.Show(responseString);
                    return (responseString);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception#0:client-server", "Error");
                return ("Error");
            }
        }
        public string get2()
        {
            try
            {
                    var request = (HttpWebRequest)WebRequest.Create($"{hrefurl12was()}nonsuch/get2.php");
                    request.Timeout = 120000;
                    var postData = "get=True";
                    postData += "&date=" + DateTime.Now.ToString();
                    postData += "&pcuser=" + strHostName;
                    var dat = Encoding.ASCII.GetBytes(postData);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = dat.Length;

                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(dat, 0, dat.Length);
                    }
                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    return (responseString);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception#0:client-server", "Error");
                return ("Error");
            }
        }
        public string get3()
        {
            try
            {
                    var request = (HttpWebRequest)WebRequest.Create($"{hrefurl12was()}nonsuch/get3.php");
                    request.Timeout = 120000;
                    var postData = "get=True";
                    postData += "&date=" + DateTime.Now.ToString();
                    postData += "&pcuser=" + strHostName;
                    var dat = Encoding.ASCII.GetBytes(postData);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = dat.Length;

                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(dat, 0, dat.Length);
                    }
                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    return (responseString);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception#0:client-server", "Error");
                return ("Error");
            }
        }
        public bool access(string keycode, string login)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create($"{hrefurl12was()}nonsuch/access.php");
                request.Timeout = 120000;
                var postData = "getaccess=True";
                postData += "&keycode=" + keycode;
                postData += "&login=" + login;
                postData += "&date=" + DateTime.Now.ToString();
                postData += "&pcuser=" + strHostName;
                postData += "&keycode=" + keycode;
                var dat = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = dat.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(dat, 0, dat.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                MessageBox.Show(responseString);
                if (responseString.Contains("access"))
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception#0:client-server", "Error");
                return false;
            }
        }
        public string auth(ref string nick, ref string password, string keycode)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create($"{hrefurl12was()}nonsuch/login_nonsuch.php");
                request.Timeout = 120000;
                var postData = "btn_auth=True";
                postData += "&login=" + nick;
                postData += "&password=" + password;
                postData += "&date=" + DateTime.Now.ToString();
                postData += "&pcuser=" + strHostName;
                postData += "&keycode=" + keycode;
                var dat = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = dat.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(dat, 0, dat.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return (responseString);
            }
            catch (Exception)
            {
                MessageBox.Show($"Exception#1:client-server", "Error");
                return ("Error");
            }
        }
        public string register(ref string nick, ref string password, string keycode)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create($"{hrefurl12was()}nonsuch/register_nonsuch.php");
                request.Timeout = 120000;
                var postData = "btn_register=True";
                postData += "&login=" + nick;
                postData += "&password=" + password;
                postData += "&date=" + $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
                postData += "&pcuser=" + strHostName;
                postData += "&keycode=" + keycode;
                var dat = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = dat.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(dat, 0, dat.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return (responseString);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Exception#2:client-server\r\n{e}", "Error");
                return ("Error");
            }
        }
        public string nickdupe(string nick, string keycode)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create($"{hrefurl12was()}nonsuch/register_nickdupe_nonsuch.php");
                request.Timeout = 120000;
                var postData = "btn_register=True";
                postData += "&login=" + nick.ToLower();
                postData += "&date=" + DateTime.Now.ToString();
                postData += "&pcuser=" + strHostName;
                postData += "&keycode=" + keycode;
                var dat = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = dat.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(dat, 0, dat.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return (responseString);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception#3:client-server", "Error");
                return ("Error");
            }
        }
    }
}
