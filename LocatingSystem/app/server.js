const express = require("express")

const app = express();

app.use(express.json());

app.get('/', (req, res)=>{
    res.send('Executing Web Server');
})

const PORT = process.env.PORT || 2300;

app.listen(PORT, ()=>{console.log('SUCCESS port server', PORT)});