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
        public async Task<string> ReadFile(string path)
        {
            Task<string> readSecretFile = File.ReadAllTextAsync(path);
            return await readSecretFile;
        }

        public async void WriteFile(string path, string content)
        {
            await File.WriteAllTextAsync(path, content);
        }
    }
}
