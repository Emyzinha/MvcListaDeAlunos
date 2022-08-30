using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller 
{

    //  public static  List <EstudanteViewModel> estudantes =
    //     new List<EstudanteViewModel>();

    public static  List <EstudanteViewModel> estudantes =
        new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Danyelle Gomes", "Rua x , 1", true),
        new EstudanteViewModel(2, "João Gomes", "Rua x , 1", true),
        new EstudanteViewModel(3, "Pedro Gomes", "Rua x , 1", false),
        new EstudanteViewModel(4, "Paulo Gomes", "Rua x , 1", true)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}