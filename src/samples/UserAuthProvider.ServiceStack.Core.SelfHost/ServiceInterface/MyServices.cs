﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.
namespace UserAuthProvider.ServiceStack.Core.SelfHost.ServiceInterface
{
    using global::ServiceStack;
    using ServiceModel;

    public class MyServices : Service
    {
        [Authenticate]
        public object Get(Hello request)
        {
            var session = GetSession();

            return new HelloResponse { Result = $"Hello, {session.FirstName}!" };
        }

        public object Post(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
