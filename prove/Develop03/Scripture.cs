using System;

class Scripture
{
    private string scriptureText;
    private Reference scriptureReference;

    public Scripture(Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        scriptureText = _scriptureText;
        
    }
}