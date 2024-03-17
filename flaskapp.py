import flask
import os
import io


app = flask.Flask(__name__)

@app.route('/', methods=['Get'])
def getDummyNames():
    return '''<div> Dummy Names </div>'''
