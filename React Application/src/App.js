// App.js in your React app
import React, { useState, useEffect } from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  const [messageFromWpf, setMessageFromWpf] = useState('');

  useEffect(() => {
    const handleMessage = (event) => {
      if (typeof event.data === 'string') {
        setMessageFromWpf(event.data);
      }
    };

    window.addEventListener('message', handleMessage);
    return () => window.removeEventListener('message', handleMessage);
  }, []);

  const sendMessageToWpf = () => {
    // Check if the method is available to avoid errors in a standard browser
    if (window.chrome.webview && window.chrome.webview.postMessage) {
      window.chrome.webview.postMessage('Changed using React button');
    }
  };

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>{messageFromWpf || 'Edit src/App.js and save to reload.'}</p>
        <button onClick={sendMessageToWpf}>Send Message to WPF</button>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
