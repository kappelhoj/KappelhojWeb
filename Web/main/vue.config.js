module.exports ={
    pages:{
        "index":{
            entry: "./src/pages/Home/main.js",
            template: "public/index.html",
            title: "Home",
            chunks: ["chunk-vendors", "chunk-common", "index"]
        },
        "dev":{
            entry: "./src/pages/Dev/main.js",
            template: "public/index.html",
            title: "Home",
            chunks: ["chunk-vendors", "chunk-common", "dev"]
        },
    }
}