body{
    margin:0;
    display:flex;
    flex-direction: column;
    align-items: center;
    height: 100vh;
    font-family: sans-serif;
    justify-content: center;
    background:url("https://media.istockphoto.com/id/1225155638/photo/green-leaves-on-white.jpg?s=612x612&w=0&k=20&c=WnoOiIq__jqzZ8uLk8PmUocXqzMp1WjiCocYOINPBFk=") ;
    background-repeat: no-repeat;
    background-size: cover;
    overflow: hidden;

}


h2{
    text-transform: uppercase;
    letter-spacing: 3px;
    font-size: 22px;
    text-align: center;
    font-style: normal;
    color: brown;
    opacity: 2.0;
}

.clock{
    display: flex;
}

.clock div{
    margin:5px;
    position: relative;
}

.clock span{
    width:100px;
    height:80px;
    background:slateblue;
    color: white;
    opacity: .7;
    display: flex;
    justify-content: center;
    align-items: center;
    font-size: 30px;
    text-shadow:2px 2px 4px ;
}

.clock .text{
    height: 20px;
    font-size: 10px;
    text-transform: uppercase;
    letter-spacing: 2px;
    background: darkblue;
    opacity: 0.8;
}

.clock #ampm{
    bottom:0;
    position: absolute;
    width:60px;
    height: 30px;
    background: olivedrab;

}
