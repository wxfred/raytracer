﻿namespace Tools
{
    public class ConsoleApplication
    {
        [Command]
        public void Diff(string source, string target)
        {
            var imgSource = new Image(source);
            var imgTarget = new Image(target);

            var result = imgTarget.Diff(imgSource);
        }
    }
}