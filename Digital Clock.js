const hour=document.getElementById("hours");

const minute=document.getElementById("minutes");


const second=document.getElementById("seconds")

const ap=document.getElementById("ampm");

function clock(){
    let h=new Date().getHours();
    let m=new Date().getMinutes();
    let s=new Date().getSeconds();
    let ampm=hour >= 12 ? "PM": "Am";
    
    h=h<10 ? "0"+h: h;
    m=m<10 ?"0"+m : m;
    s=s<10 ? "0"+s:s;

    hour.innerText=h;
    minute.innerText=m;
    second.innerText=s;
    ap.innerText=ampm;

   

    setTimeout(()=>{
        clock()
    },1000)

    
}

clock();
