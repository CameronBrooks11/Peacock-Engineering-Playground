using Leap71.ShapeKernel;
using PicoGK;

string strOutputFolder = "D:/repos/Peacock-Engineering-Playground/out";

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




/* // example showcase
try
{
    PicoGK.Library.Go(0.5f, PicoGKExamples.BooleanShowCase.Task);
}

catch (Exception e)
{
    // Apparently something went wrong, output here
    Console.WriteLine(e);
}
 */