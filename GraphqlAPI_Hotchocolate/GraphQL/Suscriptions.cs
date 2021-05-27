using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlAPI_Hotchocolate.GraphQL
{
    public class Suscriptions
    {
        [SubscribeAndResolve]
        public async IAsyncEnumerable<string> OnCompletedTasksAsync() {
            yield return "Installation started";
            await Task.Delay(1000);

            yield return "Progress 25%";
            await Task.Delay(1000);

            yield return "Installation complete!";
            await Task.Delay(1000);
        }
    }
}
