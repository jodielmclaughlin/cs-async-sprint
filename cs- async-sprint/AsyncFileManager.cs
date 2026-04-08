using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs__async_sprint
{
    public class AsyncFileManager
    {
        //AsyncFileManager.ReadFile("\cs- async-sprint\SuperSecretFile.txt")
        public string ReadFile(string path)
        {
            var readSecretFile = File.ReadAllTextAsync(path);
            return readSecretFile.Result;
        }

        public void WriteFile(string path, string content)
        {
            File.WriteAllTextAsync(path, content);
        }
    }
}
