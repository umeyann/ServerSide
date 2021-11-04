using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

public class IndexModel : PageModel
{
 
 public string Message { get; set; } = "";
    [DataType(DataType.Text)]
    public string Name { get; set; }
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [DataType(DataType.EmailAddress)]
    public string Mail { get; set; }
    [DataType(DataType.PhoneNumber)]
    public string Tel { get; set; }
    public void OnGet()
    {
        Message = "メッセージを入力してください";
    }
    public void OnPost(string name, string password, string mail, string tel)
    {
        if (name == null) name = "";
        if (password == null) password = "";
        if (mail == null) mail = "";
        if (tel == null) tel = "";
        Message = "[Name:" + name + ",password:" + password + "("
       + password.Length + "),mail:" + mail + ":,tel:" + tel + "]";
    }
}


//public class IndexModel : PageModel
//{
//    private readonly ILogger<IndexModel> _logger;
//    public IndexModel(ILogger<IndexModel> logger)
//    {
//        _logger = logger;
//    }
//    public string Message { get; set; } = "";
//    private string[][] data = new string[][]
//    {
//        new string[]{"GO3A" , "GO3A@ecc.ac.jp"},
//        new string[]{"GR4A" , "GR4A@ecc.ac.jp"},
//        new string[]{"GR4B" , "GR4B@ecc.ac.jp"},
//        new string[]{"GR4C" , "GR4C@ecc.ac.jp"}
//    };
//    [BindProperty(SupportsGet = true)]
//    public int id { get; set; }
//    public void OnGet()
//    {
//        Message = "New Set Message!";
//    }
//    public string GetData(int id)
//    {
//        string str = "";
//        if (id >= data.Length)
//        {
//            str = "Data index Out Of Bounds";
//        }
//        else
//        {
//            str = "[名前:" + data[id][0] + " , メール:" + data[id][1] + "]";
//        }
//        return str;
//    }
//}