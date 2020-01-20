const express = require('express')
const app = express()
const port = 80

let shelters = {
    "shelter5": {
        "inventory": {
            "diapers": 5
        }
    }
};


app.use(express.json());
app.use(express.static('public'));

app.get('/inventory', function(req, res) {
    const type = req.query.type;
    const shelter = req.query.shelter;
    if (shelter in shelters) {
        if (type in shelters[shelter].inventory) {
            res.send({count: shelters[shelter].inventory[type]});
            return;
        }
    }
    res.send({count: 0});
});
app.post('/inventory', function(req, res) {
    const type = req.query.type;
    const shelter = req.query.shelter;
    if (!(shelter in shelters)) {
        shelters[shelter] = {
            inventory: {}
        };
    }
    shelters[shelter].inventory[type] = req.body.count;
    res.send('success');
});

app.listen(port, () => console.log(`Example app listening on port ${port}!`))
