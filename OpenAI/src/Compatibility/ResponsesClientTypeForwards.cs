// Copyright (c) Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

[assembly: TypeForwardedTo(typeof(OpenAI.Responses.ResponsesClient))]
// Type forwarder — это механизм .NET, который сообщает компилятору/рантайму, что тип «переехал» в другую сборку.
// Благодаря этому старые зависимости, которые ждут тип в исходной DLL, продолжают работать без пересборки.

// Что делает конкретно:
// Сборка OpenAI.dll объявляет: «тип ResponsesClient ищите в OpenAI.Responses.dll».
// Любой код, ссылающийся на OpenAI.ResponsesClient (как будто он в OpenAI.dll), будет прозрачно перенаправлен в нужную DLL.
// Это решает ошибки вроде CS7069, когда тип ожидается в одной сборке, но реально находится в другой.
