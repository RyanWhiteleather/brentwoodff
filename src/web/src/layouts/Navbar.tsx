import { useState } from 'react';
import {
  IconTrophy,
  IconList,
  IconClipboardList,
  IconArchive,
  IconUser,
  IconNotes,
    } from '@tabler/icons-react';
import classes from './Navbar.module.css';

const data = [
  { link: '', label: 'Standings', icon: IconList },
  { link: '', label: 'Teams', icon: IconUser },
  { link: '', label: 'Champions', icon: IconTrophy },
  { link: '', label: 'The Draft', icon: IconClipboardList },
  { link: '', label: 'Records', icon: IconArchive },
  { link: '', label: 'Constitution', icon: IconNotes },
];

export function Navbar() {
  const [active, setActive] = useState('Billing');

  const links = data.map((item) => (
    <a
      className={classes.link}
      data-active={item.label === active || undefined}
      href={item.link}
      key={item.label}
      onClick={(event) => {
        event.preventDefault();
        setActive(item.label);
      }}
    >
      <item.icon className={classes.linkIcon} stroke={1.5} />
      <span>{item.label}</span>
    </a>
  ));

  return (
      <div className={classes.navbarMain}>
        {links}
      </div>

  );
}