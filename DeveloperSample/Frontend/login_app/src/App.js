import { useState } from "react";
import './App.css';
//import LoginForm from './LoginForm';
// import LoginAttemptList from './LoginAttemptList';
import { LoginForm } from './components/LoginForm';
import { LoginAttemptList } from "./components/LoginAttemptList";

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([]);

  return (
    <div className="App">
      {/* <LoginForm onSubmit={({ login, password }) => console.log({ login, password })} /> */}
      <LoginForm loginAttempts={loginAttempts} setLoginAttempts={setLoginAttempts} />
      <LoginAttemptList loginAttempts={loginAttempts} setLoginAttempts={setLoginAttempts} />

      {/* <div className="Attempt-List-Main">
        <p>Recent activity</p>
          <input type="input" placeholder="Filter..." />
        <ul className="Attempt-List">
                { loginAttempts.map((loginAttempt) => (
                <li key={loginAttempt.username}>
                    <span>{loginAttempt.username}</span>
                </li>
                )) }
        </ul>
      </div> */}
    </div>
  );
};

export default App;
