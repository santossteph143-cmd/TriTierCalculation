using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller { 
    public IActionResult Index() { return View(); }

    [HttpPost]
    public IActionResult Calculate(double l1, double w1, double h1,
                                   double l2, double w2, double h2,
                                   double l3, double w3, double h3)
    {
        // Math Calculation
        double v1 = l1 * w1 * h1;
        double v2 = l2 * w2 * h2;
        double v3 = l3 * w3 * h3;
        double total = v1 + v2 + v3;

        // I-save ang total volume
        ViewBag.Total = total;

        // I-save ang mga inputs para hindi mawala sa screen
        ViewBag.L1 = l1; ViewBag.W1 = w1; ViewBag.H1 = h1;
        ViewBag.L2 = l2; ViewBag.W2 = w2; ViewBag.H2 = h2;
        ViewBag.L3 = l3; ViewBag.W3 = w3; ViewBag.H3 = h3;

        return View("Index");
    }
}