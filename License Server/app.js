const express = require('express');
const exphbs = require('express-handlebars');
const handlebars = require('handlebars')
const { allowInsecurePrototypeAccess } = require('@handlebars/allow-prototype-access');
const bodyParser = require('body-parser');
const path = require('path');
const db = require('./config/database');

db.authenticate()
  .then(() => console.log("Database connected!"))
  .catch((err) => console.log(`Error: ${err}`));

const app = express();

app.engine('handlebars', exphbs.engine({
  defaultLayout: 'main',
  handlebars: allowInsecurePrototypeAccess(handlebars)
}));
app.set('view engine', 'handlebars');


// Body Parser
app.use(express.urlencoded({ extended: false }));

// Set static folder
app.use(express.static(path.join(__dirname, 'public')));

// support parsing of application/json type post data
app.use(bodyParser.json());

//support parsing of application/x-www-form-urlencoded post data
app.use(bodyParser.urlencoded({ extended: true }));

// Index route
app.get('/', (req, res) => res.render('index', { layout: 'landing' }));

//app.get('/', (req, res) => {res.send('INDEX')});

app.use('/keys', require('./routes/keys'))

const PORT = 8080;

db.sync();

app.listen(PORT, console.log(`Server started on port ${PORT}`));