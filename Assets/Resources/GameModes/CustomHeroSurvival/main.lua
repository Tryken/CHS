function onInitGame()
    print("onInitGame")
    require "items/index"
end
GameManagerAPI.onInitGame.add(onInitGame);

function onStartGame()
    print("onStartGame")
end
GameManagerAPI.onStartGame.add(onStartGame);

function onRunGame()
    print("onRunGame")
end
GameManagerAPI.onRunGame.add(onRunGame); 

function onStopGame()
    print("onStopGame")
end
GameManagerAPI.onStopGame.add(onStopGame);

function onCloseGame()
    print("GAYBAR")
end
GameManagerAPI.onCloseGame.add(onCloseGame);
