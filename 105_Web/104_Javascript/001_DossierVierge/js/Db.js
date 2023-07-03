class Db{
    static async fetchData(_url){
        let response = await fetch(this.source);
        let json = await response.json();
        return json;
    }
}
  
export {Db};