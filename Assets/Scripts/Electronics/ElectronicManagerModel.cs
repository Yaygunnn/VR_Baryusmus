using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronicManagerModel 
{
    public BaseElectronicController CurrentElectronicController;

    public List<BaseElectronicController> AllElectronics=new List<BaseElectronicController>();

    public InputScript inputScript;
}
