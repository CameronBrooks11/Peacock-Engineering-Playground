using Leap71.ShapeKernel;
using PicoGK;

string strOutputFolder = "C:/Users/Cameron/Peacock-Engineering-Playground/Out";

try
{
    PicoGK.Library.Go(
        0.1f,
        Leap71.ShapeKernelExamples.BaseCylinderShowCase.Task,
        strOutputFolder
        );
}
catch (Exception e)
{
    Console.WriteLine("Failed to run Task.");
    Console.WriteLine(e.ToString());
}