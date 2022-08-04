function onInitGame()
    print("onInitGame")
end
GameManager.onInitGame.add(onInitGame);

function onStartGame()
    print("onStartGame")
end
GameManager.onStartGame.add(onStartGame);

function onRunGame()
    print("onRunGame")
end
GameManager.onRunGame.add(onRunGame); 

function onStopGame()
    print("onStopGame")
end
GameManager.onStopGame.add(onStopGame);

function onCloseGame()
    print("GAYBAR")
end
GameManager.onCloseGame.add(onCloseGame);