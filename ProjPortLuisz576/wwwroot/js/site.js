//DETAIL_CODE
const detail_code = document.getElementById('detail_code')
if(detail_code){
    setInterval(()=>{detail_code.innerHTML == "_" ? detail_code.innerHTML="" : detail_code.innerHTML = "_"}, 500)
}