const express = require('express');
const router = express.Router();
const db = require('../config/database');
const Keys = require('../models/Keys');
const { Op } = require("sequelize");

router.get('/', (req, res) => {
    Keys.findAll()
    .then((keys) => {
        console.log(keys);
        res.render('keys', {
            keys
        });
    })
    .catch((err) => console.log(`Error: ${err}`));
});


router.get('/add', (req, res) => res.render('add'));


router.post('/add', (req, res) => {

    let { key, type, duration, condition } = req.body;
    let errors = [];

  // Validate Fields
    if(!key) {
        errors.push({ text: 'Please add a key' });
    }
    if(!type) {
        errors.push({ text: 'Please add a key-type' });
    }
    if(!duration) {
        errors.push({ text: 'Please add a duration' });
    }
    if(!condition) {
        errors.push({ text: 'Please add a condition' });
    }

    // Check for errors
    if(errors.length > 0) {
        res.render('add', {
        errors,
        key,
        type,
        duration,
        condition
        });
    } else {

        Keys.create({
            key: key,
            type: type,
            duration: duration,
            //activatedAt: activatedAt,
            condition: condition
        })
        .then(keys => {
            res.redirect('/keys');
            res.sendStatus(200);
        })
        .catch(err => console.log(`Error: ${err}`));


    }
});

router.get('/search', (req, res) => {
    let { term } = req.query;

    // Make lowercase
    //term = term.toLowerCase();

    Keys.findAll({ where: { key: { [Op.like]: '%' + term + '%' } } })
      .then(keys => res.render('keys', { keys }))
      .catch(err => res.render('error', {error: err}));
  });


router.post('/delete', (req, res) => {
    Keys.destroy({
        where: {
            id: req.body.id
        }
    })
    .then(keys => {
        res.redirect('/keys');
        res.sendStatus(200);
    })
    .catch(err => console.log(`Error: ${err}`));
});


router.get('/check', (req, res) => {
    let { term } = req.query;

    // Make lowercase
    //term = term.toLowerCase();

    Keys.findOne({ where: { key: term} } )
      .then(keys => res.send(keys))
      .catch(err => res.send(err));
  });



router.get('/edit', (req, res) => {
    let { id } = req.query;
    Keys.findOne({where: {id: id}})
    .then(keys => res.render('edit', {keys}))
    .catch(err => res.render('error', {error: err}));
});


router.post('/edit', (req, res) => {
    Keys.update(
        {
            key: req.body.key,
            type: req.body.type,
            duration: req.body.duration,
            condition: req.body.condition
        },
        {
            where: {
                id: req.body.id
        }
    })
    .then(keys => {
        res.redirect('/keys');
        res.sendStatus(200);
    })
    .catch(err => console.log(`Error: ${err}`));
});




module.exports = router